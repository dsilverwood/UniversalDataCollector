using System;
using System.Linq;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Collections.Generic;

namespace UniversalDataCollector.GUI
{
    public partial class frmBase : Form
    {
        private List<Control> allButtons;
        private List<ToolStripMenuItem> allMenus = new List<ToolStripMenuItem>();
        protected SpeechRecognitionEngine speech = null;

        public frmBase()
        {
        }

        virtual protected void LoadGrammar(Form form)
        {
            speech.UnloadAllGrammars();

            allButtons = GetControls(form, typeof(Button)).ToList();
            Grammar buttonGrammar = GetButtonGrammar(form, allButtons);
            if (allButtons.Count > 0)
                speech.LoadGrammar(buttonGrammar);

            List<Control> MenuStrips = GetControls(form, typeof(MenuStrip)).ToList();
            foreach (Control c in MenuStrips)
            {
                ToolStripItemCollection menuItems = ((MenuStrip)c).Items;
                foreach (ToolStripMenuItem t in menuItems)
                    allMenus.Add(t);
            }
            if (allMenus.Count > 0)
                speech.LoadGrammar(GetMenuGrammar(this, allMenus));
        }

        virtual protected void InitializeSpeech()
        {
            if (speech == null)
            {
                speech = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
                speech.SetInputToDefaultAudioDevice();
                speech.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Recognized);
                Activated += new EventHandler(Base_Activated);
                Deactivate += new EventHandler(Base_Deactivate);
            }

            LoadGrammar(this);
        }

        protected void FinalizeSpeech()
        {
            if(speech != null)
            {
                speech.Dispose();
                speech = null;
            }
        }

        virtual protected void Recognized(object sender, SpeechRecognizedEventArgs e)
        {
            ToolStripMenuItem menuItem = null;

            //if (String.Equals(e.Result.Text.ToLower() , "ok"))
            //{
            //    if (e.Result.Confidence < 0.60)
            //        return;
            //}
            //else if (e.Result.Confidence < 0.80)
            //    return;
            Button button = (Button)allButtons.FirstOrDefault(x => x.Text.ToLower().Contains(e.Result.Text.ToLower()));
            if (button != null)
                button.PerformClick();
            menuItem = (ToolStripMenuItem)allMenus.FirstOrDefault(x => x.Text.ToLower().Contains(e.Result.Text.ToLower()));
            if (menuItem != null)
                menuItem.PerformClick();
        }

        protected Grammar GetChoicesGrammar(string question, Choices choices)
        {
            GrammarBuilder builder = new GrammarBuilder(question);
            builder.Append(choices);
            Grammar sensorGrammar = new Grammar(builder);
            sensorGrammar.Name = "Choices";
            return sensorGrammar;
        }

        private void Base_Activated(object sender, EventArgs e)
        {
            speech.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Base_Deactivate(object sender, EventArgs e)
        {
           speech.RecognizeAsyncCancel();
        }

        private IEnumerable<Control> GetControls(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetControls(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private Grammar GetButtonGrammar(Form form, List<Control> allButtons)
        {
            Choices buttonChoices = new Choices();
            foreach (Button button in allButtons)
                buttonChoices.Add(button.Text);
            GrammarBuilder buttonBuilder = new GrammarBuilder(buttonChoices);
            Grammar buttonGrammar = new Grammar(buttonBuilder);
            buttonGrammar.Name = "Buttons";
            return buttonGrammar;
        }

        private Grammar GetMenuGrammar(Form form, List<ToolStripMenuItem> menuItems)
        {
            Choices menuChoices = new Choices();
            if (menuItems != null)
            {
                foreach (ToolStripMenuItem menu in menuItems)
                    menuChoices.Add(menu.Text);
            }
            GrammarBuilder menuBuilder = new GrammarBuilder(menuChoices);
            Grammar menuGrammar = new Grammar(menuBuilder);
            return menuGrammar;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBase
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frmBase";
            this.ResumeLayout(false);

        }
    }
}
