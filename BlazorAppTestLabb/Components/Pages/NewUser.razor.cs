namespace BlazorAppTestLabb.Components.Pages
{
    public partial class NewUser
    {
        UsersComponent userOne = new();
        private string? _name;
        private string? _city;
        private string? _phoneNumber;
        private string? _email;

        private bool _isSubmitted = false;

        public void HandleInput()
        {
            _isSubmitted = true;

        }
    }
}