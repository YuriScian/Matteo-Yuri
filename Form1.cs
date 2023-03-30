namespace Matteo_Yuri
{
    public partial class Form1 : Form
    {
        Bitmap bmp ;
        
        Bitmap bmp2;
        int R ;
        int G ;
        int B ;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();

            //foto.Filter = " yuri | *.jpg ; *.jpeg; *.bmp ; *.png";

            foto.ShowDialog();

             bmp = new Bitmap(foto.FileName);

            float fatform = (float)bmp.Width / (float)pictureBox1.Width;
            float highform = (float)bmp.Height / (float)pictureBox1.Height;

             bmp2 = new Bitmap(bmp, new Size((int)(bmp.Width / fatform), (int)(bmp.Height / highform)));

            pictureBox1.Image = bmp2;



        }
        private void trbRed_Scroll(object sender, EventArgs e)
        {
            Bitmap NewImage = new Bitmap(bmp2, bmp2.Width, bmp2.Height);
            for (int y = 0; y < NewImage.Height; y++)
            {
                for (int x = 0; x < NewImage.Width; x++)
                {
                    Color pixel = NewImage.GetPixel(x , y);
                    R = pixel.R + (trbRed.Value - 255 );

                    if (R < 0) R = 0;
                    if (R > 255) R = 255;

                    Color newpixel = Color.FromArgb( R , G , B );
                    NewImage.SetPixel(x, y, newpixel);

                }
            }
            label4.Text  = trbRed.Value.ToString();
            pictureBox1.Image = NewImage;
        }

        private void trbGreen_Scroll(object sender, EventArgs e)
        {
            Bitmap NewImage = new Bitmap(bmp2, bmp2.Width, bmp2.Height);

            

            for (int y = 0; y < NewImage.Height; y++)
            {
                for (int x = 0; x < NewImage.Width; x++)
                {
                    Color pixel = NewImage.GetPixel(x, y);
                    
                    G = pixel.G + (trbGreen.Value - 255);

                    if (G < 0) G = 0;
                    if (G > 255) G = 255;

                    Color newpixel = Color.FromArgb( R, G , B ) ;
                    NewImage.SetPixel(x, y, newpixel);

                }
            }
            label5.Text = trbGreen.Value.ToString();
            pictureBox1.Image = NewImage;
        }

        private void trbBlue_Scroll_1(object sender, EventArgs e)
        {



            Bitmap NewImage = new Bitmap(bmp2, bmp2.Width, bmp2.Height);   
            for (int y = 0; y < NewImage.Height; y++)
            {
                for (int x = 0; x < NewImage.Width; x++)
                {
                    Color pixel = NewImage.GetPixel(x, y);

                    B = pixel.B + (trbBlue.Value -255 );

                    if (B < 0) B = 0;
                    if (B > 255) B = 255;

                    Color newpixel = Color.FromArgb( R, G, B );
                    NewImage.SetPixel(x, y, newpixel);

                }
            }
            label6.Text = trbBlue.Value.ToString();
            pictureBox1.Image = NewImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trbRed.Value = 255;
            trbGreen.Value = 255;
            trbBlue.Value = 255;
            
        }
    }

}