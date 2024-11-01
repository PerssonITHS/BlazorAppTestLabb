using BlazorAppTestLabb.Model;

namespace BlazorAppTestLabb.Components.Pages
{
    public partial class UsersComponent
    {
        private bool _pageIsLoading = true;
        private bool _showingAllUsers = false;

        private DataAccess? _dataAccess;
        private List<User>? _registeredUsers;
        private List<User>? _allUsersToShow;
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            _pageIsLoading = false;
            _dataAccess = new DataAccess();
            _registeredUsers = _dataAccess.GetUsers().OrderBy(x => x.Name).ToList().GetRange(0, 5).ToList();
            _allUsersToShow = _dataAccess.GetUsers().OrderBy(x => Random.Shared.Next()).ToList();
        }

        public void ShowAllUsers()
        {
            _showingAllUsers = true;
        }
        public void ShowTopFiveUsers()
        {
            _showingAllUsers = false;
        }

    }
    
}
