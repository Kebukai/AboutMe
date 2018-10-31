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
        public ObservableCollection<Skill> Skills { get; set;}
		public SkillPage ()
		{
			InitializeComponent ();

            this.Skills = new ObservableCollection<Skill>();
            this.Skills.Add(new Skill
                {Name = "Public Speaking", Description = "Experience with speaking infront of people"});
            this.Skills.Add(new Skill
                {Name = "Creativity", Description = "Can think outside the box" });
            this.Skills.Add(new Skill
                {Name = "Procrastinating", Description = "Loves to do things at the last mintute" });

            SkillList.ItemsSource = this.Skills;
        }
	}

    public class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}