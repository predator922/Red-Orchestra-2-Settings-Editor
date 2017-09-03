using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace ro2_settings_editor
{

    public partial class MainForm : Form
    {
        //DECLARATION
        private List<config> roengineP = new List<config>();
        private List<config> rogameP = new List<config>();
        private string[] roengineRaw;
        private string[] rogameRaw;
        private List<config> texQuality = new List<config>();
        private List<config> shaQuality = new List<config>();
        private List<config> lightQuality = new List<config>();
        int g;
        int g2;

        //MISC
        public string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        private string checkStringBool(bool value)
        {
            if (value)
                return "True";
            else
                return "False";
        }


        private int roengineGap()
        {
            for(int i =700; i<780; i++)
            {
                if (roengineP[i].Setting == "TEXTUREGROUP_UI")
                {
                    return i - 740;
                }

            }
            return 50;
        }

        private int rogameGap()
        {
            for (int i = 560; i < 640; i++)
            {
                if (rogameP[i].Setting == "PostProcessingPreset")
                {
                    return i - 600;
                }

            }
            return 50;
        }

        //***

        public MainForm()
        {
            try
            {
                InitializeComponent();
                roengineRaw = loadIni("ROEngine.ini");
                rogameRaw = loadIni("ROGame.ini");
                roengineP = convertIni(roengineRaw);
                rogameP = convertIni(rogameRaw);
                g = roengineGap();
                g2 = rogameGap();
                loadVideoSettings();
                getVideoSettings();
               
            }
            catch (Exception e)
            {
                MessageBox.Show("Fatal error, the program will exit now " +e.Message);
                Environment.Exit(0);
            }
        }

        private string[] loadIni(string iniName)
        {
            try
            {
                string[] a;
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                 + "\\My Games\\RedOrchestra2\\ROGame\\Config\\" + iniName;
                a = File.ReadAllLines(@path);
               // MessageBox.Show(" "+a.Length);
                if (a.Length < 1100)
                    throw new IniNotInitializedException("Go to the game and change the video setting preset to CUSTOM then come back");
                return a;
            }
            catch (FileNotFoundException ec)
            {
                MessageBox.Show("Failed lo load "+ iniName+" " + ec.Message);
                throw;
            }
            catch(IniNotInitializedException ini)
            {
                MessageBox.Show("Virgin ROEngine.ini!! " + ini.Message);
                throw;
            }
        }

        private List<config> convertIni(string[] raw)
        {
            Char delimiter1 = '=';
            String[] rawWords;
            List<config> ini = new List<config>(); ;
            for (int i = 0; i < raw.Length; i++)
            {
                rawWords = raw[i].Split(delimiter1);
                List<String> words = new List<String>(rawWords);
                if (words.Count > 1)
                {
                    if (words.Count > 2)
                    {
                        for (int j = 2; j < words.Count; j++)
                        {
                            words[1] = string.Format("{0}={1}", words[1], words[j]);
                        }
                        words.RemoveRange(2, words.Count - 2);
                    }
                    ini.Add(new config(words[0], words[1]));
                }
            }
            return ini;
        }
        private void changeVideoPreset(int quality)
        {
            if (quality < 4) {
                detailcombo.SelectedIndex = quality;
                chacombo.SelectedIndex = quality;
                texcombo.SelectedIndex = quality + 1;
                anisocombo.SelectedIndex = quality + 1;
                shadowcombo.SelectedIndex = quality;
                aacombo.SelectedIndex = quality + 1;
                postcombo.SelectedIndex = quality;
                lightcombo.SelectedIndex = quality;
                if (quality == 3)
                {
                    greencombo.SelectedIndex = 2;
                    fxcombo.SelectedIndex = 2;
                }
                else
                {
                    greencombo.SelectedIndex = quality;
                    fxcombo.SelectedIndex = quality;
                }       
            }
            else
            {
                getVideoSettings();
            }
        }



        private void loadVideoSettings()
        {
            List<string> quality = new List<string>();
            quality.Add("Lowest");
            quality.Add("Low");
            quality.Add("Medium");
            quality.Add("High");
            quality.Add("Ultra");
            quality.Add("Custom");

            List<string> aaquality = new List<string>();
            aaquality.Add("Off");
            aaquality.Add("FXAA Low");
            aaquality.Add("FXAA Medium");
            aaquality.Add("FXAA High");
            aaquality.Add("MLAA Ultra");

            List<string> anisoquality = new List<string>();
            anisoquality.Add("Off");
            anisoquality.Add("2x");
            anisoquality.Add("4x");
            anisoquality.Add("8x");
            anisoquality.Add("16x");

            List<string> pp = new List<string>();
            pp.Add("Normal");
            pp.Add("Enhanced");
            pp.Add("War Movie");

            ppCombo.DataSource = pp;
            detailcombo.DataSource = quality.GetRange(1, 4);
            chacombo.DataSource = quality.GetRange(1, 4);
            texcombo.DataSource = quality.GetRange(0, 5); ;
            shadowcombo.DataSource = quality.GetRange(1, 4);
            fxcombo.DataSource = quality.GetRange(1, 3);
            aacombo.DataSource = aaquality;
            postcombo.DataSource = quality.GetRange(1, 4);
            lightcombo.DataSource = quality.GetRange(1, 4);
            greencombo.DataSource = quality.GetRange(1, 3);
            anisocombo.DataSource = anisoquality;
            presetcombo.DataSource = quality.GetRange(1, 5);

        }

        private void getVideoSettings()
        {
            detailcombo.SelectedIndex = Int32.Parse(roengineP[684+g].Value);
            chacombo.SelectedIndex = Int32.Parse(roengineP[754 + g].Value);
            texcombo.SelectedIndex = Int32.Parse(roengineP[755 + g].Value);
            shadowcombo.SelectedIndex = Int32.Parse(roengineP[756 + g].Value);
            aacombo.SelectedIndex = getAAQuality();
            fxcombo.SelectedIndex = Int32.Parse(roengineP[760 + g].Value);
            postcombo.SelectedIndex = Int32.Parse(roengineP[758 + g].Value);
            lightcombo.SelectedIndex = Int32.Parse(roengineP[757 + g].Value);
            greencombo.SelectedIndex = getFoliageQuality();
            ppCombo.SelectedIndex = getPPPquality();
            anisocombo.SelectedIndex = getAnisoQuality();
            occbox.Checked = roengineP[759 + g].Value == "1";
            aocheck.Checked = roengineP[662 + g].Value == "True";
            bloomcheck.Checked = roengineP[663 + g].Value == "True";
            lshaftcheck.Checked = roengineP[665 + g].Value == "True";
            blurcheck.Checked = roengineP[752 + g].Value == "True";
            dofcheck.Checked = roengineP[661 + g].Value == "True";
            resX.Text = roengineP[695 + g].Value;
            resY.Text = roengineP[696 + g].Value;
            vsyncCheck.Checked = roengineP[677 + g].Value == "True";
            fullCheck.Checked = roengineP[679 + g].Value == "True";
            physCheck.Checked = roengineP[949 + g].Value == "False";
            smoothCheck.Checked = getFrameLock();
            presetcombo.SelectedIndex = 4;
            texQuality = GetDetailValues(0, texcombo.SelectedIndex);
            shaQuality = GetDetailValues(1, shadowcombo.SelectedIndex);
            lightQuality = GetDetailValues(2, lightcombo.SelectedIndex);

        }
        public static void ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 200;
            prompt.Height = 200;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            NumericUpDown inputBox = new NumericUpDown() { Left = 50, Top = 50, Width = 40 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            //return (int)inputBox.Value;
        }
        private int getAnisoQuality()
        {
            switch (roengineP[686 + g].Value)
            {
                case "16": return 4; break;
                case "8": return 3; break;
                case "4": return 2; break;
                case "2": return 1; break;
                case "1": return 0; break;
                default: return 0; break;
            }

        }
        private int getPPPquality() {
            if (rogameP[600+g2].Value == "ROPPP_WarMovie")
            {
                return 2;
            }
            else
            { 
                if (rogameP[600+g2].Value == "ROPPP_Normal")
                    return 0;
                else
                    return 1;
            }
        }
    
        private bool getFrameLock()
        {
            return (roengineP[163].Value.ToUpper() == "TRUE" || roengineP[941 + g].Value.ToUpper() == "TRUE");
        }

        private int getFoliageQuality()
        {
            if (roengineP[699 + g].Value == "0.500000")
            {
                return 0;
            }
            else
            {
                if (roengineP[699 + g].Value == "0.750000")
                    return 1;
                else
                    return 2;
            }
        }

        private int getAAQuality()
        {
            if (roengineP[768 + g].Value == "True")
            {
                return 4;
            }
            else
            {
                if (roengineP[769 + g].Value == "False")
                {
                    return 0;
                }
                else
                {
                    return Int32.Parse(roengineP[770 + g].Value) + 1 - (Int32.Parse(roengineP[770 + g].Value) / 3);
                }
            }
        }

        private void saveINI(string []raw, List<config> processed, string iniName) {
            try
            {
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                 + "\\My Games\\RedOrchestra2\\ROGame\\Config\\"+iniName;
                int k = 0;
                for (int i = 0; i < processed.Count; i++)
                {
                    while (raw[k] == "" || raw[k][0] == '[')
                    {
                        k++;
                    }
                    raw[k] = string.Format("{0}={1}", processed[i].Setting, processed[i].Value);
                    k++;
                }
                File.WriteAllLines(@path, raw);
                MessageBox.Show(iniName+" saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveSet_Click(object sender, EventArgs e)
        {
            roengineP[684 + g].Value = detailcombo.SelectedIndex.ToString();

            roengineP[754 + g].Value = chacombo.SelectedIndex.ToString();
            if (chacombo.SelectedIndex == 0)
                roengineP[682 + g].Value = "1";

            roengineP[755 + g].Value = texcombo.SelectedIndex.ToString();
            changeTextureQuality(texcombo.SelectedIndex);

            roengineP[756 + g].Value = shadowcombo.SelectedIndex.ToString();
            changeShadowQuality(shadowcombo.SelectedIndex);

            roengineP[760 + g].Value = fxcombo.SelectedIndex.ToString();
            if (fxcombo.SelectedIndex == 0)
                roengineP[683 + g].Value = "2";
            else
                roengineP[683 + g].Value = (1 / fxcombo.SelectedIndex).ToString();

            changeAAQuality(aacombo.SelectedIndex);

            roengineP[758 + g].Value = postcombo.SelectedIndex.ToString();
            changePostQuality(postcombo.SelectedIndex);

            roengineP[757 + g].Value = lightcombo.SelectedIndex.ToString();
            changeLightQuality(lightcombo.SelectedIndex);

            changeFoliageQuality(greencombo.SelectedIndex);

            if (occbox.Checked)
                roengineP[759 + g].Value = "1";
            else
                roengineP[759 + g].Value = "0";

            roengineP[752 + g].Value = checkStringBool(blurcheck.Checked);
            roengineP[661 + g].Value = checkStringBool(dofcheck.Checked);
            roengineP[662 + g].Value = checkStringBool(aocheck.Checked);
            roengineP[663 + g].Value = checkStringBool(bloomcheck.Checked);
            roengineP[665 + g].Value = checkStringBool(lshaftcheck.Checked);
            roengineP[677 + g].Value = checkStringBool(vsyncCheck.Checked);
            roengineP[679 + g].Value = checkStringBool(fullCheck.Checked);
            roengineP[949 + g].Value = checkStringBool(!physCheck.Checked);

            changeResolution();
            changeFrameLock(smoothCheck.Checked);
           changePPPquality(ppCombo.SelectedIndex);
            changeAnisoQuality(anisocombo.SelectedIndex);

            saveINI(rogameRaw, rogameP, "ROGame.ini");
            saveINI(roengineRaw, roengineP, "ROEngine.ini");
        }
        private void changeAnisoQuality(int quality)
        {
            roengineP[686 + g].Value = ((int)Math.Pow(2, quality)).ToString();
        }
        private void changePPPquality(int quality)
        {
            if (quality == 0)
            {
                rogameP[600+g2].Value = "ROPPP_Normal";
            }
            else
            {
                if (quality == 1)
                    rogameP[600+g2].Value = "ROPPP_Enhanced";
                else
                    rogameP[600+g2].Value = "ROPPP_WarMovie";
            }
        }

        private void changeFrameLock(bool b) {
            if (b)
            {
                roengineP[163].Value = "TRUE";
                roengineP[941 + g].Value = "True";
            }
            else
            {
                roengineP[163].Value = "FALSE";
                roengineP[941 + g].Value = "False";
            }
        }

        private void changePostQuality(int quality)
        {
            switch (quality)
            {
                case 0:
                    roengineP[788 + g].Value = "0.100000";
                    break;
                case 1:
                    roengineP[788 + g].Value = "0.250000";
                    break;
                case 2:
                    roengineP[788 + g].Value = "0.500000";
                    break;
                case 3:
                    roengineP[788 + g].Value = "1.000000";
                    break;
            }
        }

        private void changeResolution()
        {
            if (resX.Text != "" && resY.Text != "")
            {
                try
                {
                    roengineP[695 + g].Value = Convert.ToInt32(resX.Text).ToString();
                    roengineP[696 + g].Value = Convert.ToInt32(resY.Text).ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Resolution must be a number!!!");
                }

            }
        }

        private void changeFoliageQuality(int quality)
        {
            if (quality == 0)
            {
                roengineP[699 + g].Value = "0.500000";
            }
            else
            {
                if (quality == 1)
                    roengineP[699 + g].Value = "0.750000";
                else
                    roengineP[699 + g].Value = "1.000000";
            }
        }

        private void changeAAQuality(int quality)
        {
            if (quality < 4)
            {
                if (quality == 0)
                {
                    roengineP[768 + g].Value = "False";
                    roengineP[769 + g].Value = "False";
                    roengineP[770 + g].Value = "0";
                }
                else
                {
                    roengineP[768 + g].Value = "False";
                    roengineP[769 + g].Value = "True";
                    roengineP[770 + g].Value = (quality - 1 + (quality / 3)).ToString();
                }
            }
            else
            {
                roengineP[768 + g].Value = "True";
                roengineP[769 + g].Value = "False";
                roengineP[770 + g].Value = "0";
            }
        }

        private void changeTextureQuality(int quality)
        {
            string mmf;
            string mip;

            if (texQuality[5].Value == "1")
                mmf = "Linear";
            else
                mmf = "Aniso";
            if (texQuality[6].Value == "0")
                mip = "Point";
            else
                mip = "Linear";

            for (int p = 0; p < 3; p++)
            {
                roengineP[727 + p + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[3].Value, mmf, mip);
                roengineP[730 + p + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[4].Value, mmf, mip);
                roengineP[733 + p + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[4].Value, mmf, mip);
            }

            roengineP[724 + g].Value = string.Format("(MinLODSize=64,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", Int32.Parse(texQuality[4].Value) - Int32.Parse(texQuality[4].Value) / 4, mmf, mip);
            roengineP[725 + g].Value = string.Format("(MinLODSize=64,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[4].Value, mmf, mip);
            roengineP[726 + g].Value = string.Format("(MinLODSize=64,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[4].Value, mmf, mip);
            roengineP[736 + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", "0", mmf, mip);
            roengineP[737 + g].Value = string.Format("(MinLODSize=64,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[4].Value, mmf, mip);
            roengineP[738 + g].Value = string.Format("(MinLODSize=64,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[4].Value, mmf, mip);
            roengineP[739 + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[4].Value, mmf, mip);
            roengineP[740 + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[0].Value, mmf, mip);
            roengineP[741 + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[1].Value, mmf, mip);
            roengineP[742 + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},NumStreamedMips=3,MipGenSettings=TMGS_SimpleAverage)", texQuality[2].Value, mmf, mip);
            roengineP[743 + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", "0", "Aniso", "Point");


            for (int p = 0; p < 5; p++)
            {
                roengineP[744 + p + g].Value = string.Format("(MinLODSize=1,MaxLODSize=4096,LODBias={0},MinMagFilter={1},MipFilter={2},MipGenSettings=TMGS_SimpleAverage)", texQuality[4].Value, mmf, mip);
            }

        }

        private void changeShadowQuality(int quality)
        {
            roengineP[708 + g].Value = shaQuality[0].Value;
            roengineP[690 + g].Value = shaQuality[7].Value;
            roengineP[691 + g].Value = shaQuality[2].Value;
            roengineP[692 + g].Value = shaQuality[6].Value;
            roengineP[785 + g].Value = shaQuality[3].Value;
            roengineP[786 + g].Value = shaQuality[4].Value;
            roengineP[787 + g].Value = shaQuality[5].Value;
            roengineP[700 + g].Value = shaQuality[8].Value;
            roengineP[706 + g].Value = shaQuality[9].Value;
            for (int p = 0; p < 5; p++)
            {
                roengineP[791 + p + g].Value = shaQuality[10 + p].Value;
            }

        }

        private void changeLightQuality(int quality)
        {
            roengineP[653 + g].Value = ToTitleCase(lightQuality[3].Value);
            roengineP[665 + g].Value = ToTitleCase(lightQuality[2].Value);
            roengineP[666 + g].Value = ToTitleCase(lightQuality[0].Value);
            roengineP[667 + g].Value = ToTitleCase(lightQuality[1].Value);
            roengineP[751 + g].Value = ToTitleCase(lightQuality[4].Value);

        }

        private List<config> GetDetailValues(int n, int i)
        {
            int p = 0;
            if (n > 0)
                p = p + n * 4 + 1;
            string[] values = roengineP[916 + p + i + g].Value.Split(',');
            values[0] = values[0].Split('(')[1];
            values[values.Length - 1] = values[values.Length - 1].Split(')')[0];
            List<config> values2 = new List<config>();

            for (int k = 0; k < values.Length; k++)
            {
                values2.Add(new config(values[k].Split('=')[0], values[k].Split('=')[1]));
            }

            return values2;
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            getVideoSettings();
        }

        private void advanced_Click(object sender, EventArgs e)
        {
            AdvancedSettingsForm form2;
            if (sender == a0)
            {
               form2 = new AdvancedSettingsForm(texQuality);
                
            }
            else
            {
                if (sender == a1)
                {
                    form2 = new AdvancedSettingsForm(shaQuality);

                }
                else
                {
                    form2 = new AdvancedSettingsForm(lightQuality);
                }
            }
            form2.ShowDialog();
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == texcombo)
            {
                texQuality = GetDetailValues(0, texcombo.SelectedIndex);

            }
            else
            {
                if (sender == shadowcombo)
                {
                    shaQuality= GetDetailValues(1, shadowcombo.SelectedIndex);

                }
                else
                {
                    lightQuality= GetDetailValues(2, lightcombo.SelectedIndex);
                }
            }
            
        }

        private void presetcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeVideoPreset(presetcombo.SelectedIndex);
        }


    }
}
