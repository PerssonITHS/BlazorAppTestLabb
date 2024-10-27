namespace BlazorAppTestLabb.Components.Pages
{
    public partial class Weather
    {
        Counter userOne = new Counter();
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