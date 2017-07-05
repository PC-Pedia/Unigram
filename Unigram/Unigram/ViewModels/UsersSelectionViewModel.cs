﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Aggregator;
using Telegram.Api.Helpers;
using Telegram.Api.Services;
using Telegram.Api.Services.Cache;
using Telegram.Api.TL;
using Telegram.Api.TL.Contacts;
using Template10.Services.NavigationService;
using Unigram.Collections;
using Unigram.Common;
using Unigram.Views;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Unigram.ViewModels
{
    public abstract class UsersSelectionViewModel : UnigramViewModelBase
    {
        public UsersSelectionViewModel(IMTProtoService protoService, ICacheService cacheService, ITelegramEventAggregator aggregator) 
            : base(protoService, cacheService, aggregator)
        {
            Items = new SortedObservableCollection<TLUser>(new TLUserComparer(false));
            SelectedItems = new ObservableCollection<TLUser>();
            SelectedItems.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            SendCommand.RaiseCanExecuteChanged();
        }

        #region Overrides

        public virtual string Title => "Title";

        public virtual int Maximum => 5000;
        public virtual int Minimum => 0;

        public ListViewSelectionMode SelectionMode => Maximum > 1 ? ListViewSelectionMode.Multiple : ListViewSelectionMode.None;

        public virtual bool AllowGlobalSearch => true;

        protected virtual Func<TLUser, bool> Filter => null;

        #endregion

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            var contacts = CacheService.GetContacts();
            foreach (var item in contacts.OfType<TLUser>())
            {
                var user = item as TLUser;
                if (user.IsSelf)
                {
                    continue;
                }

                if (Filter != null)
                {
                    if (Filter(user))
                    {
                        Items.Add(user);
                    }
                }
                else
                {
                    Items.Add(user);
                }
            }

            var input = string.Join(",", contacts.Select(x => x.Id).Union(new[] { SettingsHelper.UserId }).OrderBy(x => x));
            var hash = Utils.ComputeMD5(input);
            var hex = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();

            var response = await ProtoService.GetContactsAsync(hex);
            if (response.IsSucceeded && response.Result is TLContactsContacts)
            {
                var result = response.Result as TLContactsContacts;
                if (result != null)
                {
                    Items.Clear();

                    foreach (var item in result.Users.OfType<TLUser>())
                    {
                        var user = item as TLUser;
                        if (user.IsSelf)
                        {
                            continue;
                        }

                        if (Filter != null)
                        {
                            if (Filter(user))
                            {
                                Items.Add(user);
                            }
                        }
                        else
                        {
                            Items.Add(user);
                        }
                    }
                }
            }
        }

        public SortedObservableCollection<TLUser> Items { get; private set; }

        public ObservableCollection<TLUser> SelectedItems { get; private set; }

        private RelayCommand _sendCommand;
        public RelayCommand SendCommand => _sendCommand = _sendCommand ?? new RelayCommand(SendExecute, () => Minimum <= SelectedItems.Count && Maximum >= SelectedItems.Count);
        protected virtual void SendExecute()
        {

        }
    }
}
