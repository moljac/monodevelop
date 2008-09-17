// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.ChangeLogAddIn {
    
    
    public partial class ProjectOptionPanelWidget {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label label1;
        
        private Gtk.RadioButton parentRadioButton;
        
        private Gtk.Label label4;
        
        private Gtk.RadioButton noneRadioButton;
        
        private Gtk.Label label3;
        
        private Gtk.RadioButton nearestRadioButton;
        
        private Gtk.Label label5;
        
        private Gtk.RadioButton oneChangeLogInProjectRootDirectoryRadioButton;
        
        private Gtk.Label label6;
        
        private Gtk.RadioButton oneChangeLogInEachDirectoryRadioButton;
        
        private Gtk.Label label7;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.ChangeLogAddIn.ProjectOptionPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.ChangeLogAddIn.ProjectOptionPanelWidget";
            // Container child MonoDevelop.ChangeLogAddIn.ProjectOptionPanelWidget.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Select the ChangeLog policy that applies for this project:");
            this.vbox2.Add(this.label1);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox2[this.label1]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.parentRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("radiobutton2"));
            this.parentRadioButton.CanFocus = true;
            this.parentRadioButton.Name = "parentRadioButton";
            this.parentRadioButton.Active = true;
            this.parentRadioButton.DrawIndicator = true;
            this.parentRadioButton.UseUnderline = true;
            this.parentRadioButton.Group = new GLib.SList(System.IntPtr.Zero);
            this.parentRadioButton.Remove(this.parentRadioButton.Child);
            // Container child parentRadioButton.Gtk.Container+ContainerChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("<b>Use parent solution policy</b>\nApply the policy specified in the parent solution.");
            this.label4.UseMarkup = true;
            this.parentRadioButton.Add(this.label4);
            this.vbox2.Add(this.parentRadioButton);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.parentRadioButton]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.noneRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("radiobutton1"));
            this.noneRadioButton.CanFocus = true;
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.DrawIndicator = true;
            this.noneRadioButton.UseUnderline = true;
            this.noneRadioButton.Group = this.parentRadioButton.Group;
            this.noneRadioButton.Remove(this.noneRadioButton.Child);
            // Container child noneRadioButton.Gtk.Container+ContainerChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("<b>Disable ChangeLog support</b>\nNo ChangeLog entries will be generated for this project.");
            this.label3.UseMarkup = true;
            this.noneRadioButton.Add(this.label3);
            this.vbox2.Add(this.noneRadioButton);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox2[this.noneRadioButton]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.nearestRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Custom policy"));
            this.nearestRadioButton.CanFocus = true;
            this.nearestRadioButton.Name = "nearestRadioButton";
            this.nearestRadioButton.DrawIndicator = true;
            this.nearestRadioButton.UseUnderline = true;
            this.nearestRadioButton.Group = this.parentRadioButton.Group;
            this.nearestRadioButton.Remove(this.nearestRadioButton.Child);
            // Container child nearestRadioButton.Gtk.Container+ContainerChild
            this.label5 = new Gtk.Label();
            this.label5.WidthRequest = 500;
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("<b>Update nearest ChangeLog</b>\nThe nearest ChangeLog file in the directory hierarchy will be updated (below the commit directory). If none is found, a warning message will be shown. ChangeLog files will never be automatically created.");
            this.label5.UseMarkup = true;
            this.label5.Wrap = true;
            this.nearestRadioButton.Add(this.label5);
            this.vbox2.Add(this.nearestRadioButton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox2[this.nearestRadioButton]));
            w7.Position = 3;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.oneChangeLogInProjectRootDirectoryRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("One ChangeLog in the project root directory"));
            this.oneChangeLogInProjectRootDirectoryRadioButton.CanFocus = true;
            this.oneChangeLogInProjectRootDirectoryRadioButton.Name = "oneChangeLogInProjectRootDirectoryRadioButton";
            this.oneChangeLogInProjectRootDirectoryRadioButton.DrawIndicator = true;
            this.oneChangeLogInProjectRootDirectoryRadioButton.UseUnderline = true;
            this.oneChangeLogInProjectRootDirectoryRadioButton.Group = this.parentRadioButton.Group;
            this.oneChangeLogInProjectRootDirectoryRadioButton.Remove(this.oneChangeLogInProjectRootDirectoryRadioButton.Child);
            // Container child oneChangeLogInProjectRootDirectoryRadioButton.Gtk.Container+ContainerChild
            this.label6 = new Gtk.Label();
            this.label6.WidthRequest = 500;
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("<b>Single project ChangeLog</b>\nAll changes done in the project files will be logged in a single ChangeLog file, located at the project root directory. The ChangeLog file will be created if it doesn't exist.");
            this.label6.UseMarkup = true;
            this.label6.Wrap = true;
            this.oneChangeLogInProjectRootDirectoryRadioButton.Add(this.label6);
            this.vbox2.Add(this.oneChangeLogInProjectRootDirectoryRadioButton);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.oneChangeLogInProjectRootDirectoryRadioButton]));
            w9.Position = 4;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.oneChangeLogInEachDirectoryRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("One ChangeLog in each directory"));
            this.oneChangeLogInEachDirectoryRadioButton.CanFocus = true;
            this.oneChangeLogInEachDirectoryRadioButton.Name = "oneChangeLogInEachDirectoryRadioButton";
            this.oneChangeLogInEachDirectoryRadioButton.DrawIndicator = true;
            this.oneChangeLogInEachDirectoryRadioButton.UseUnderline = true;
            this.oneChangeLogInEachDirectoryRadioButton.Group = this.parentRadioButton.Group;
            this.oneChangeLogInEachDirectoryRadioButton.Remove(this.oneChangeLogInEachDirectoryRadioButton.Child);
            // Container child oneChangeLogInEachDirectoryRadioButton.Gtk.Container+ContainerChild
            this.label7 = new Gtk.Label();
            this.label7.WidthRequest = 500;
            this.label7.Name = "label7";
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("<b>One ChangeLog in each directory</b>\nFile changes will be logged in a ChangeLog located at the file's directory. The ChangeLog file will be created if it doesn't exist.");
            this.label7.UseMarkup = true;
            this.label7.Wrap = true;
            this.oneChangeLogInEachDirectoryRadioButton.Add(this.label7);
            this.vbox2.Add(this.oneChangeLogInEachDirectoryRadioButton);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox2[this.oneChangeLogInEachDirectoryRadioButton]));
            w11.Position = 5;
            w11.Expand = false;
            w11.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
