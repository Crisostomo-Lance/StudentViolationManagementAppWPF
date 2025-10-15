using StudentViolationApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StudentViolationApplication.Repositories;
using System.Net;
using System.Security.Principal;
using CommunityToolkit.Mvvm.ComponentModel;

namespace StudentViolationApplication.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {

        [ObservableProperty]
        private string _userName ="admin";

        [ObservableProperty]
        private SecureString _password ;

        [ObservableProperty]
        private string _userType;

        [ObservableProperty]
        private string _errorMessage;

        [ObservableProperty]
        private bool _isViewVisible = true;

        private IUserRepository userRepository;

       

        //Commands
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }

        //Constructor
        public LoginViewModel()
        {

            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(p => ExecuteRecoverPasswordCommand("", ""));
            //ShowPasswordCommand = new ViewModelCommand(ExecuteShowPasswordCommand);
            //RememberPasswordCommand = new ViewModelCommand(ExecuteRememberPasswordCommand);
        }

        private void ExecuteRememberPasswordCommand(object? obj)
        {
            
        }

        private void ExecuteShowPasswordCommand(object? obj)
        {
            throw new NotImplementedException();
        }

        private void ExecuteRecoverPasswordCommand(String username, String email)
        {
            throw new NotImplementedException();
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validate;

            if (String.IsNullOrWhiteSpace(UserName) || UserName.Length < 2 || Password == null || Password.Length < 5)
                validate = false;
            else
                validate = true;
            return validate;
        }

        private void ExecuteLoginCommand(object? obj)
        {

            UserName = "admin";
            //var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(UserName, Password));
            //if (isValidUser)
            //{
            //    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(UserName), null);
            //    IsViewVisible = false;
            //}
            //else
            //{
            //    ErrorMessage = "Invalid username or password. Please try again.";
            //}
        }
    }

}
