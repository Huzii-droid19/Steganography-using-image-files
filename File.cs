using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stegano
{
    class File:IFile
    {
        public void SaveImageFile(Image image)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                save.Title = "Save an Encrypted Image ";
                save.InitialDirectory = @"C:\";
                save.RestoreDirectory=true;
                save.ShowDialog();
                if (save.FileName != "")
                {
                    using (FileStream fs = (FileStream)save.OpenFile())
                    {
                        new Bitmap(image).Save(fs, ImageFormat.Bmp);
                    }

                }
            }
        }

        public string ReadImageFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return string.Empty;
                }

            }
        }
    }
}
