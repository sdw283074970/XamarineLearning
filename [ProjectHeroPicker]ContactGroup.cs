//Class

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HellowWorld
{
    public class ContactGroup : ObservableCollection<Contact>
    {
        public string Title { get; set; }
        public ContactGroup(string title)
        {
            Title = title;
        }
    }
}
