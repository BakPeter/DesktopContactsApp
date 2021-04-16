using DesktopContactsApp.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopContactsApp.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {


        public Contact Contact
        {
            get { return (Contact)GetValue(ContactProperty); }
            set { SetValue(ContactProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Contact.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContactProperty =
            DependencyProperty.Register("Contact", typeof(Contact), typeof(ContactControl), new PropertyMetadata(GetDefualtContact(), SetText));

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContactControl control = d as ContactControl;

            if (control != null)
            {
                Contact contact = e.NewValue as Contact;

                control.nameTextBlock.Text = contact.Name;
                control.emailTextBlock.Text = contact.Email;
                control.phoneTextBlock.Text = contact.Phone;
            }
        }

        private static Contact GetDefualtContact()
        {
            return new Contact() { Name = "Name LastName", Email = "example@domain.com", Phone = "1234567" };
        }


        //private Contact contact;

        //public Contact Contact
        //{
        //    get { return contact; }
        //    set
        //    {
        //        contact = value;

        //        nameTextBlock.Text = contact.Name;
        //        emailTextBlock.Text = contact.Email;
        //        phoneTextBlock.Text = contact.Phone;
        //    }
        //}

        public ContactControl()
        {
            InitializeComponent();
        }
    }
}
