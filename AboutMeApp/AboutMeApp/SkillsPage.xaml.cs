using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMeApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillsPage : ContentPage
	{
        public ObservableCollection<Skill> Skills { get; set; }
		public SkillsPage ()
		{
			InitializeComponent ();
            this.Skills = new ObservableCollection<Skill>();
            this.Skills.Add(new Skill { description = "Java Coding", name = "Java", icon = "java.png"});
            this.Skills.Add(new Skill { description = "SQL Querying", name = "SQL", icon ="database.png" });
            this.Skills.Add(new Skill { description= "HTML Writing", name = "HTML", icon ="html.png" });
            this.skillsListView.ItemsSource = this.Skills;
        }
        
    }
    public class Skill
    {
        public string icon { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}