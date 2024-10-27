using BlazorAppTestLabb.Model;

namespace BlazorAppTestLabb.Components.Pages
{
    public partial class Counter
    {
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            _pageIsLoading = false;
            _dataAccess = new DataAccess();
            _userList = _dataAccess.GetUsers().OrderBy(x => x.Name).ToList().GetRange(0, 5).ToList();
            _showAllUsers = _dataAccess.GetUsers().OrderBy(x => Random.Shared.Next()).ToList();
        }

        private bool _pageIsLoading = true;
        private bool _showingAllUsers = false;

        private DataAccess? _dataAccess;
        private List<Users>? _userList;
        public List<Users>? _showAllUsers;

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
