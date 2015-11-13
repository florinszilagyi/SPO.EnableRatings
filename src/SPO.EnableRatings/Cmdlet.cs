using System.Management.Automation;
using Microsoft.SharePoint.Client;

namespace SPO.EnableRatings
{
    [Cmdlet(VerbsCommon.Set, "SPORating")]
    public class Cmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [Alias("List")]
        public string ListName { get; set; }

        [Parameter(Mandatory = true)]
        [Alias("VotingExperience")]
        public VotingExperience RatingType { get; set; }

        [Parameter(Mandatory = true)]
        [Alias("ClientContext")]
        public ClientContext Context { get; set; }

        protected override void ProcessRecord()
        {
            var enabler = new RatingsEnabler(Context);
            enabler.Enable(ListName, RatingType);
        }
    }
}
