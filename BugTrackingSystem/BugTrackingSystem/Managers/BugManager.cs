using BugTrackingSystem.Models;

namespace BugTrackingSystem.Managers
{
    public class BugManager
    {
        public BugManager() { }

        public IEnumerable<BugModel> GetAllBugs()
        {
            return new[] {
               new BugModel
               {
                   Id = 1,
                   Title = "Dropdown menu is empty",
                   Author = "Elihle",
                   Description = "The drink dropdown menu does not have list of drinks",
                   Status = 1,
               },
               new BugModel
               {
                   Id = 1,
                   Title = "Submit button is missing",
                   Author = "Sipho",
                   Description = "The the buttom to submit the form is missing",
                   Status = 1,
               },
               new BugModel
               {
                   Id = 1,
                   Title = "Menu link not clickable",
                   Author = "Sipho",
                   Description = "The menu link is not clickable when trying to access main menu",
                   Status = 1,
               }
               };
        }
    }
}
