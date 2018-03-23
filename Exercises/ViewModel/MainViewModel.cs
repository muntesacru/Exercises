using Exercises.Classes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace Exercises.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            receiver = new ReceiverClass();
        }

        public ReceiverClass receiver { get; set; }

        public ICommand SendTextMessageCommand => new RelayCommand(() =>
        {
            SenderClass sender = new SenderClass();
            sender.SendTextMessage("MessageType1");
        });

        public ICommand SendCustomMessageCommand => new RelayCommand(() =>
        {
            SenderClass sender = new SenderClass();
            sender.SendCustomMessage(9999, "ErrorDescription");
        });
    }
}