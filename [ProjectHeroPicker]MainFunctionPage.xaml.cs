using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HellowWorld
{
    public partial class ListPage : ContentPage
    {
        private ObservableCollection<ContactGroup> _contacts;

        //滑动英雄区块选项菜单，选择标记
        void Mark_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Message", contact.Name + " has been marked", "ok");
        }

        //滑动英雄区块选项菜单，弃用该建议英雄
        void Ban_Clicked(object sender, System.EventArgs e)
        {
            var contact =(sender as MenuItem).CommandParameter as Contact;
            for (int i = 0; i < _contacts.Count; i++) {
                _contacts[i].Remove(contact);
            }

        }

        //选择英雄区块事件，暂设定为空
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
            listView.SelectedItem = null;
		}

        //点击英雄区块事件，暂设定为弹出确认窗口
        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var contact2 = e.Item as Contact;
            string selectname2 = "Select " + contact2.Name + " as your hero";
            DisplayAlert("Tapped", selectname2, "ok");
        }

        public ListPage()
        {
            InitializeComponent();

            //对英雄进行分组
            _contacts = new ObservableCollection<ContactGroup>{
                
                //这里写对应的从输出优势英雄列表中对各角色分类的方法
                new ContactGroup("Carry") {
                    new Contact { Name = "PA", ImageSrc = ImageSource.FromResource("pa"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
                    new Contact { Name = "POM", ImageSrc = ImageSource.FromResource("pom"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
                    new Contact { Name = "CM", ImageSrc = ImageSource.FromResource("cm"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"}

                },  

                new ContactGroup("Mid") {
					new Contact { Name = "PA", ImageSrc = ImageSource.FromResource("pa"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
					new Contact { Name = "POM", ImageSrc = ImageSource.FromResource("pom"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
					new Contact { Name = "CM", ImageSrc = ImageSource.FromResource("cm"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"}
                },

                new ContactGroup("OffLane") {
					new Contact { Name = "PA", ImageSrc = ImageSource.FromResource("pa"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
					new Contact { Name = "POM", ImageSrc = ImageSource.FromResource("pom"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
					new Contact { Name = "CM", ImageSrc = ImageSource.FromResource("cm"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"}
                },

                new ContactGroup("Jungle") {
			        new Contact { Name = "PA", ImageSrc = ImageSource.FromResource("pa"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
					new Contact { Name = "POM", ImageSrc = ImageSource.FromResource("pom"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
					new Contact { Name = "CM", ImageSrc = ImageSource.FromResource("cm"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"}
                },

                new ContactGroup("Roam") {
                    new Contact { Name = "PA", ImageSrc = ImageSource.FromResource("pa"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
                    new Contact { Name = "POM", ImageSrc = ImageSource.FromResource("pom"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
                    new Contact { Name = "CM", ImageSrc = ImageSource.FromResource("cm"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"}
                },

                new ContactGroup("Support") {
                    new Contact { Name = "PA", ImageSrc = ImageSource.FromResource("pa"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
                    new Contact { Name = "POM", ImageSrc = ImageSource.FromResource("pom"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"},
                    new Contact { Name = "CM", ImageSrc = ImageSource.FromResource("cm"), ScoreTotal="6", Score1="1", Score2="2", Score3="3", Score4="4", Score5="5"}
                }
            };

            listView.ItemsSource = _contacts;
        }
    }
}
