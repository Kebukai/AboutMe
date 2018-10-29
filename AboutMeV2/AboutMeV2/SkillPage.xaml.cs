using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeV2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillPage : ContentPage
	{
        public ObservableCollection<Skill> Skills(get; set;)
		public SkillPage ()
		{
			InitializeComponent ();

            this.Skills = new ObservableCollection<Skill>();
            this.Skills.Add(new Skill
                {Name = "A", Description = "B"});
            this.Skills.Add(new Skill
                {Name = "A", Description = "B" });
            this.Skills.Add(new Skill
                {Name = "A", Description = "B" });
        }
	}

    public class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}