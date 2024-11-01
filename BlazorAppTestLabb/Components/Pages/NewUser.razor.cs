namespace BlazorAppTestLabb.Components.Pages
{
    public partial class NewUser
    {
        UsersComponent userOne = new();
        private string? _name;
		private string? _email;
		private string? _id;
		private string? _street;
		private string? _zipCode;
		private string? _city;
        private string? _company;
        private string? _companyCatchPhrase;

        private bool _isSubmitted = false;
        public void HandleInput()
        {
            _isSubmitted = true;
        }
    }
}
