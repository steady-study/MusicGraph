using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using SeeSharpTools.JY.GUI;
using SeeSharpTools.JY.DSP.Fundamental;

//원본작업...,,..,우선 올려놈. 여기서 push한거 어디갔는지 모르겠다.
namespace MusicGraph
{
    public partial class Form1 : Form
    {

        


        private Thread checkThread;
        private bool MExit = false;
        byte[] data = null;   //0. 대상데이타파일객체
        
        int a;
        double Dble;
        double DDble;
        //public static double ToDouble(sbyte value);

        [DllImport("winmm.dll")]
        private static extern long mciSendstring(string _command, StringBuilder _returnData,
            int _returnLength, IntPtr _hwndCallBack);
        OpenFileDialog opf = new OpenFileDialog();


        public Form1()
        {
            InitializeComponent();            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            opf.Filter = "Wav File|*.wav";
            opf.InitialDirectory = Environment.CurrentDirectory;
            //string fname = "wavEX.wav";
            //FileInfo dFile = new FileInfo(fname);

        //1. 파일읽어오기
        //File_Load();
            //int bytesCount = (int)dFile.Length;
            //byte[] data = new byte[bytesCount];

               
        //2. 읽어온 데이타파일 담아오기 작업수행
        }
        public void OpenFile()
        {
            
        }

        private void click_Click(object sender, EventArgs e)
        {
            

            if (opf.ShowDialog() == DialogResult.OK)
            {
                string fname = opf.FileName;
                FileInfo dFile = new FileInfo(fname);
                int bytesCount = (int)dFile.Length;
                data = new byte[bytesCount];
            }
            else
                return;
            
            


            //checkThread = new Thread(Music_Data);
            //checkThread.Start();

            //1. 파일읽어오기
            //File_Load();
            //2. 읽어온 데이타파일 담아오기 작업수행
        }

        private void play_Click(object sender, EventArgs e)
        {
            /*
            double[] signal = new double[a];
            double[] noise = new double[signal.Length];
            double[] spectrum = new double[signal.Length / 2];
            double df;

            Generation.SineWave(ref signal, 1, 0, 600, 10000);
            Generation.UniformWhiteNoise(ref noise, 0.1);
            ArrayCalculation.Add(signal, noise, ref signal);
            spectrum.PowerSpectrum(signal, 10000, ref spectrum,out df);
            */


            ///////////////////////////////////////////////
            /*
            int size;
            size = Convert.ToInt32(a);
            //le = Convert.ToDouble(a);
            double[] signal = new double[size];
            //DDble = Convert.ToDouble(Dble);

            easyChart3.Plot(signal,0,1);
            */
            ////////////////////////////////////////////////

            checkThread = new Thread(Music_Data);
            checkThread.Start();

        }

        private void Music_Data()
        {
            while (!MExit)
            {
                for (int i = 0; i<data.Length; i++)
                {
                    data[i] = Convert.ToByte(i);
                    a = Convert.ToInt32(data[i]);

                    Debug.WriteLine("{0}", a);

                }
                pb.CreateGraphics();
                Thread.Sleep(100);
                
            }
            //Spectrum.AdvanceRealFFT(,a,) G = a;
                
                //3.  담아온 바이트 데이타로 그래프그리기
            
        }

        

        //funtion test
        

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;



            Pen pen = new Pen(Color.Red);
            G.DrawLine(pen, 0, Math.Abs(a-pb.Height), 0, 0);
            

            //timer1_Tick;
            
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkThread.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkThread.Start();
        }

        

        
    }
}
