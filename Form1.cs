using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CRCCalc
{
    public partial class CrcMainForm : Form
    {
        private char[] SepChars = { ' ', '\n', '\r', '.' };
        private char[] WhitespaceChars = { ' ', '\n', '\r' };
        private byte[] CurrentCrcInput = null;
        private const ushort Crc16Poly = 0xA001;
        private const ushort Can15Poly = 0xC599;


        public CrcMainForm()
        {
            InitializeComponent();
        }

        private void Crc16GoButton_Click(object sender, EventArgs e)
        {
            ushort CrcRes = ushort.Parse(initValTextBox.Text, System.Globalization.NumberStyles.AllowHexSpecifier);
            ushort CrcTemp;

            ParseCrcDataText();

            // If using strings
            //Crc16ResultTextBox.Text = "";
            //foreach (string HexString in Values)
            //        CrcTemp = Convert.ToUInt16(HexString, 16);

            foreach (byte newByte in CurrentCrcInput)
            {
                try
                {
                    CrcTemp = newByte;
                    CrcRes = (ushort)(CrcRes ^ (CrcTemp & 0xFFu));
                    for (int Bit_Index = 0; Bit_Index < 8; Bit_Index++)
                    {
                        int Carry = CrcRes & 0x0001;
                        CrcRes = (ushort)(CrcRes >> 1);
                        if (Carry > 0)
                            CrcRes = (ushort)(CrcRes ^ Crc16Poly);
                    }
                }
                catch
                {

                }
            }
            Crc16ResultTextBox.Text = CrcRes.ToString("X4");
        }

        private void ccittButton_Click(object sender, EventArgs e)
        {
            ushort CrcRes = ushort.Parse(initValTextBox.Text, System.Globalization.NumberStyles.AllowHexSpecifier);
            byte CrcTemp;

            ParseCrcDataText();

            try
            {
                foreach (byte newByte in CurrentCrcInput)
                {
                    CrcTemp = (byte)((CrcRes >> 8) ^ newByte);
                    CrcTemp ^= (byte)(CrcTemp >> 4);
                    CrcRes = (ushort)((CrcRes << 8) ^ ((ushort)(CrcTemp << 12)) ^ ((ushort)(CrcTemp << 5)) ^ ((ushort)CrcTemp));
                }
                ccittResultTextBox.Text = CrcRes.ToString("X4");
            }
            catch
            {

            }
        }

        private void can15Button_Click(object sender, EventArgs e)
        {
            ushort CrcRes = 0x0;

            ParseCrcDataText();

            try
            {
                CrcRes = 0;
                foreach (byte newByte in CurrentCrcInput)
                {
                    CrcRes = (ushort)(CrcRes ^ (newByte << 7));

                    for (int j = 0; j < 8; j++)
                    {
                        CrcRes <<= 1;
                        if ((CrcRes & 0x8000) == 0x8000)
                        {
                            CrcRes ^= Can15Poly;
                        }
                    }

                    CrcRes &= 0x7fff;
                }
                can15ResultTextBox.Text = CrcRes.ToString("X4");
            }
            catch
            {

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();

            FileDialog.RestoreDirectory = true;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenDataFile(FileDialog.FileName);
            }
        }

        private void ParseCrcDataText()
        {
            CrcSourceTextBox.Text = CrcSourceTextBox.Text.TrimEnd(WhitespaceChars);
            if (CrcSourceTextBox.Text.EndsWith("..."))
            {
                // Data already in the array
                return;
            }
            else
            {
                string[] Values = CrcSourceTextBox.Text.Split(SepChars);
                try
                {
                    CurrentCrcInput = Values.Select(s => Convert.ToByte(s, 16)).ToArray();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Exception: " + Ex.Message);
                }
            }
        }

        public byte[] FileToByteArray(string fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName,
                                           FileMode.Open,
                                           FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            return buff;
        }

        private void CrcMainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            OpenDataFile(FileList[0]);
        }

        private void CrcSourceTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            OpenDataFile(FileList[0]);
        }

        private void CrcMainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void CrcSourceTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void OpenDataFile(string FileName)
        {
            String displayText = "";
            CurrentCrcInput = FileToByteArray(FileName);
            int numBytes = 0;

            foreach (byte newByte in CurrentCrcInput)
            {
                displayText += newByte.ToString("X2") + " ";
                numBytes++;
                if(numBytes % 32 == 0)
                    displayText += Environment.NewLine;

                if (numBytes == 0x1000)
                {
                    displayText += "...";
                    CrcSourceTextBox.Text = displayText;
                    return;
                }
            }

            Crc16ResultTextBox.Text = displayText;
        }

        private void lrc8Button_Click(object sender, EventArgs e)
        {
            ushort XorRes;
            ushort XorTemp;

            ParseCrcDataText();

            try
            {
                XorTemp = 0;
                foreach (byte newByte in CurrentCrcInput)
                {
                    XorTemp = (ushort)(XorTemp ^ newByte);
                }
                XorRes = (ushort)((ushort)((XorTemp & 0x00F0) << 8) + (ushort)(XorTemp & 0x000F));
                lrc8ResultTextBox.Text = XorRes.ToString("X4");
            }
            catch
            {

            }
        }
    }
}
