﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        // float W, H, w, h, /*x0, y0,*/ k;

        public Form1()
        { InitializeComponent(); }

        private void DrawSky()
        {
            // Начало работы
            g = CreateGraphics();
            g.Clear(SystemColors.Control);

            // Размеры формы
            /*W = ClientSize.Width;
            H = ClientSize.Height;

            if ((W / 16 * 9) < H)
            {
                w = 1;
                int t = Convert.ToInt32(Math.Round(W / 16)) * 16;
                while (w % 16 != 0)
                {
                    if (t < W) { W--; }
                    else if (t > W) { W++; }
                    else if (t == W) { w = W; }
                }

                k = w / 16;
                h = k * 9;
            }
            if ((W / 16 * 9) > H)
            {
                h = 1;
                int t = Convert.ToInt32(Math.Round(H / 9)) * 9;
                while (h % 9 != 0)
                {
                    if (t < H) { H--; }
                    else if (t > H) { H++; }
                    else if (t == H) { h = H; }
                }

                k = h / 9;
                w = k * 16;
            }

            //x0 = (W - w) / 2;
            //y0 = (H - h) / 2;
            
            // Коэфициент масштаба объектов
            k = 0; */



            // Фон
            SolidBrush background = new SolidBrush(Color.FromArgb(140, 165, 189));
            g.FillRectangle(background, 0, 0, 1280, 720);
            SolidBrush test = new SolidBrush(Color.Black);

            // Кисти для облаков
            SolidBrush cl1 = new SolidBrush(Color.FromArgb(99, 119, 148));
            SolidBrush cl2 = new SolidBrush(Color.FromArgb(66, 81, 112));
            SolidBrush cl3 = new SolidBrush(Color.FromArgb(41, 50, 86));
            SolidBrush cl4 = new SolidBrush(Color.FromArgb(20, 28, 66));
            SolidBrush cl5 = new SolidBrush(Color.FromArgb(8, 12, 52));

            // Облака 1
            g.FillEllipse(cl1, -16,-2,34,34);
            g.FillEllipse(cl1, -41,-4, 195, 116);
            g.FillEllipse(cl1, 117,21, 104, 93);
            g.FillEllipse(cl1, 199,5, 76, 74);
            g.FillEllipse(cl1, 260, 0, 72, 69);
            g.FillEllipse(cl1, 287, 15, 87, 77);
            g.FillEllipse(cl1, 358, 36, 98, 75);
            g.FillEllipse(cl1, 452, 65, 49, 42);
            g.FillEllipse(cl1, 474, 48, 61, 56);
            g.FillEllipse(cl1, 517, 29, 88, 80);
            g.FillEllipse(cl1, 598, 53, 56, 54);
            g.FillEllipse(cl1, 652, 63, 41, 41);
            g.FillEllipse(cl1, 662, 24, 56, 54);
            g.FillEllipse(cl1, 703, 13, 88, 58);
            g.FillEllipse(cl1, 767, 13, 24, 23);
            g.FillEllipse(cl1, 779, 10, 88, 72);
            g.FillEllipse(cl1, 865, 28, 42, 43);
            g.FillEllipse(cl1, 884, 1, 81, 83);
            g.FillEllipse(cl1, 936, -9, 44, 47);

            g.FillRectangle(cl1, 117, 50, 325, 90);
            g.FillRectangle(cl1, 442, 75, 180, 70);
            g.FillRectangle(cl1, 690, 50, 180, 47);
            g.FillRectangle(cl1, 900, 50, 180, 50);
            g.FillRectangle(cl1, 950, 0, 300, 50);
           

            // Облака 2
            g.FillEllipse(cl2, -23, 89, 92, 59);
            g.FillEllipse(cl2, 52, 72, 105, 88);
            g.FillEllipse(cl2, 135, 64, 87, 78);
            g.FillEllipse(cl2, 184, 79, 86, 83);
            g.FillEllipse(cl2, 256, 99, 105, 84);
            g.FillEllipse(cl2, 344, 131, 86, 83);
            g.FillEllipse(cl2, 377, 113, 83, 83);
            g.FillEllipse(cl2, 428, 94, 97, 89);
            g.FillEllipse(cl2, 514, 123, 62, 60);
            g.FillEllipse(cl2, 573, 134, 37, 36);
            g.FillEllipse(cl2, 582, 93, 58, 54);
            g.FillEllipse(cl2, 622, 83, 79, 42);
            g.FillEllipse(cl2, 695, 78, 36, 31);
            g.FillEllipse(cl2, 724, 72, 54, 43);
            g.FillEllipse(cl2, 768, 88, 41, 37);
            g.FillEllipse(cl2, 802, 84, 64, 51);
            g.FillEllipse(cl2, 847, 58, 102, 83);
            g.FillEllipse(cl2, 945, 78, 68, 55);
            g.FillEllipse(cl2, 1009, 83, 58, 64);
            g.FillEllipse(cl2, 1019, 31, 97, 79);
            g.FillEllipse(cl2, 1083, 5, 139, 76);
            g.FillEllipse(cl2, 1200, -2, 123, 83);

            g.FillRectangle(cl2, 0, 130, 350, 90);
            g.FillRectangle(cl2, 570, 150, 350, 35);
            g.FillRectangle(cl2, 600, 100, 600, 60);
            g.FillRectangle(cl2, 1090, 50, 190, 60);


            //Облака 3
            g.FillEllipse(cl3, -58, 160, 146, 76);
            g.FillEllipse(cl3, 71, 176, 95, 83);
            g.FillEllipse(cl3, 146, 154, 87, 83);
            g.FillEllipse(cl3, 216, 141, 83, 75);
            g.FillEllipse(cl3, 249, 148, 90, 88);   
            g.FillEllipse(cl3, 326, 166, 103, 83);
            g.FillEllipse(cl3, 420, 174, 95, 83);
            g.FillEllipse(cl3, 487, 156, 96, 101);
            g.FillEllipse(cl3, 573, 173, 55, 59);
            g.FillEllipse(cl3, 621, 138, 106, 103);
            g.FillEllipse(cl3, 705, 138, 58, 52);
            g.FillEllipse(cl3, 756, 146, 59, 55);
            g.FillEllipse(cl3, 808, 164, 31, 34);
            g.FillEllipse(cl3, 827, 166, 60, 41);
            g.FillEllipse(cl3, 858, 144, 86, 83);
            g.FillEllipse(cl3, 905, 116, 128, 113);
            g.FillEllipse(cl3, 1010, 138, 95, 86);
            g.FillEllipse(cl3, 1090, 156, 32, 30);
            g.FillEllipse(cl3, 1114, 77, 184, 147);

            g.FillRectangle(cl3, 0, 200, 1280, 90);
            g.FillRectangle(cl3, 700, 170, 300, 80);
            g.FillRectangle(cl3, 1000, 160, 280, 50);


            // Облака 4
            g.FillEllipse(cl4, 9, 264, 146, 76);
            g.FillEllipse(cl4, 127, 271, 95, 83);
            g.FillEllipse(cl4, 199, 246, 87, 83);
            g.FillEllipse(cl4, 259, 213, 113, 94);
            g.FillEllipse(cl4, 334, 246, 90, 88);
            g.FillEllipse(cl4, 397, 248, 76, 67);
            g.FillEllipse(cl4, 452, 269, 43, 42);
            g.FillEllipse(cl4, 483 , 248, 73, 77);
            g.FillEllipse(cl4, 528, 229, 91, 89);
            g.FillEllipse(cl4, 613, 254, 58, 58);
            g.FillEllipse(cl4, 664, 264, 62, 64);
            g.FillEllipse(cl4, 678, 223, 59, 60);
            g.FillEllipse(cl4, 710, 213, 103, 94);
            g.FillEllipse(cl4, 762, 219, 60, 54);
            g.FillEllipse(cl4, 792, 220, 102, 88);
            g.FillEllipse(cl4, 888, 242, 67, 59);
            g.FillEllipse(cl4, 900, 225, 103, 100);
            g.FillEllipse(cl4, 961, 198, 125, 97);
            g.FillEllipse(cl4, 1072, 229, 103, 93);
            g.FillEllipse(cl4, 1155, 242, 41, 35);
            g.FillEllipse(cl4, 1175, 183, 95, 83);

            g.FillRectangle(cl4, 400, 280, 450, 90);


            // Облака 5
            g.FillEllipse(cl5, 387, 339, 85, 72);
            g.FillEllipse(cl5, 446, 326, 91, 79);
            g.FillEllipse(cl5, 533, 351, 59, 55);
            g.FillEllipse(cl5, 583, 357, 57, 59);
            g.FillEllipse(cl5, 622, 327, 59, 61);
            g.FillEllipse(cl5, 659, 300, 60, 65);
            g.FillEllipse(cl5, 701, 314, 63, 65);
            g.FillEllipse(cl5, 741, 339, 58, 65);
            g.FillEllipse(cl5, 781, 349, 43, 44);
            g.FillEllipse(cl5, 818, 325, 57, 59);

            cl1.Dispose();
            cl2.Dispose();
            cl3.Dispose();
            cl4.Dispose();
            cl5.Dispose();

            // Кисти для Гор
            SolidBrush mo1 = new SolidBrush(Color.FromArgb(23, 11, 24));
            SolidBrush mo2 = new SolidBrush(Color.FromArgb(35, 20, 30));
            SolidBrush mo3 = new SolidBrush(Color.FromArgb(69, 34, 48));
            SolidBrush mo4 = new SolidBrush(Color.FromArgb(51, 25, 32));

            //Горы 1
            Point[] m1 = new Point[22];

            m1[0] = new Point(0, 720);
            m1[1] = new Point(0, 276);
            m1[2] = new Point(55, 376);
            m1[3] = new Point(524, 468);
            m1[4] = new Point(546, 448);
            m1[5] = new Point(560, 488);
            m1[6] = new Point(585, 455);
            m1[7] = new Point(604, 489);
            m1[8] = new Point(620, 416);
            m1[9] = new Point(643, 471);

            m1[10] = new Point(702, 463);

            m1[11] = new Point(656, 344);

            m1[12] = new Point(839, 478);
            m1[13] = new Point(1069, 384);

            m1[14] = new Point(1022, 243);
            m1[15] = new Point(1105, 311);
            m1[16] = new Point(1099, 287);
            m1[17] = new Point(1141, 304);
            m1[18] = new Point(1111, 233);
            m1[19] = new Point(1186, 251);
            m1[20] = new Point(1280, 42);

            m1[21] = new Point(1280, 720);
            
            g.FillPolygon(mo1, m1);

            //Горы 2
            Point[] m2 = new Point[62];
            
            //
            m2[0] = new Point(0, 276);
            //

            m2[1] = new Point(54, 204);
            m2[2] = new Point(49, 306);
            m2[3] = new Point(165, 266);
            m2[4] = new Point(210, 335);
            m2[5] = new Point(353, 169);
            m2[6] = new Point(318, 285);
            m2[7] = new Point(328, 344);
            m2[8] = new Point(511, 64);
            m2[9] = new Point(431, 372);
            m2[10] = new Point(483, 347);
            m2[11] = new Point(479, 431);
            m2[12] = new Point(521, 413);
            m2[13] = new Point(517, 505);
            m2[14] = new Point(578, 520);
            m2[15] = new Point(588, 543);
            m2[16] = new Point(746, 577);
            //
            m2[17] = new Point(726, 641);
            //
            m2[18] = new Point(905, 636);
            m2[19] = new Point(901, 584);
            
            m2[20] = new Point(830, 541);

            m2[21] = new Point(818, 598);
            m2[22] = new Point(644, 476);
            m2[23] = new Point(661, 430);
            m2[24] = new Point(678, 440);
            m2[25] = new Point(688, 413);
            m2[26] = new Point(727, 430);
            m2[27] = new Point(718, 290);
            m2[28] = new Point(804, 375);
            m2[29] = new Point(797, 347);
            m2[30] = new Point(860, 381);
            
            //
            m2[31] = new Point(862, 357);
            //
            
            m2[32] = new Point(982, 427);
            m2[33] = new Point(907, 269);
            
            //
            m2[34] = new Point(1150, 339);
            m2[35] = new Point(1110, 468);
            m2[36] = new Point(1088, 450);
            //

            m2[37] = new Point(1006, 720);
            m2[38] = new Point(938, 720);
            m2[39] = new Point(895, 704);
            m2[40] = new Point(880, 720);
            m2[41] = new Point(806, 720);
            //
            m2[42] = new Point(726, 641);
            //
            m2[43] = new Point(687, 711);
            m2[44] = new Point(659, 692);
            m2[45] = new Point(650, 720);
            m2[46] = new Point(561, 720);
            m2[47] = new Point(339, 631);
            m2[48] = new Point(292, 661);
            m2[49] = new Point(237, 605);
            m2[50] = new Point(217, 656);
            m2[51] = new Point(155, 528);
            m2[52] = new Point(136, 587);
            m2[53] = new Point(122, 574);
            m2[54] = new Point(109, 603);
            m2[55] = new Point(0, 470);
            m2[56] = new Point(0, 276);

            //
            m2[57] = new Point(522, 543);
            //

            m2[58] = new Point(540, 525);
            m2[59] = new Point(580, 553);
            m2[60] = new Point(580, 553);
            m2[61] = new Point(522, 543);

            g.FillPolygon(mo2, m2);

            //Горы 3
            Point[] m3 = new Point[38];

            //
            m3[0] = new Point(0, 374);
            m3[1] = new Point(67, 332);
            m3[2] = new Point(72, 347);
            m3[3] = new Point(155, 339);
            m3[4] = new Point(169, 386);
            m3[5] = new Point(293, 333);
            m3[6] = new Point(303, 389);
            m3[7] = new Point(380, 309);
            m3[8] = new Point(389, 462);
            m3[9] = new Point(456, 436);
            
            //
            m3[10] = new Point(484, 526);
            m3[11] = new Point(726, 641);
            m3[12] = new Point(852, 649);
            m3[13] = new Point(886, 637);
            //

            m3[14] = new Point(810, 448);
            m3[15] = new Point(1001, 542);
            m3[16] = new Point(791, 248);
            m3[17] = new Point(1127, 422);
            m3[18] = new Point(1110, 468);
            m3[19] = new Point(1088, 450);
            m3[20] = new Point(1035, 625);
            m3[21] = new Point(1000, 654);
            m3[22] = new Point(921, 654);
            
            //
            m3[23] = new Point(886, 637);
            m3[24] = new Point(852, 649);
            m3[25] = new Point(726, 641);
            m3[26] = new Point(484, 526);
            //

            m3[27] = new Point(212, 502);
            m3[28] = new Point(191, 437);
            m3[29] = new Point(146, 499);
            m3[30] = new Point(128, 465);
            m3[31] = new Point(103, 482);
            m3[32] = new Point(127, 388);
            m3[33] = new Point(57, 442);
            m3[34] = new Point(45, 421);
            m3[35] = new Point(21, 430);
            m3[36] = new Point(64, 384);
            m3[37] = new Point(0, 421);

            g.FillPolygon(mo3,m3);

            /*
            // Горы 1

            Point[] m1 = new Point[23];

            m1[0] = new Point(0,720);

            m1[1] = new Point(517, 453);
            m1[2] = new Point(524, 469);
            m1[3] = new Point(542, 448);
            m1[4] = new Point(559, 489);
            m1[5] = new Point(584, 458);
            m1[6] = new Point(609, 504);
            m1[7] = new Point(619, 419);
            m1[8] = new Point(645, 472);
            m1[9] = new Point(665, 495);
            
            m1[10] = new Point(681, 420);
            m1[11] = new Point(655, 344);
            m1[12] = new Point(740, 417);

            m1[13] = new Point(1062, 324);
            m1[14] = new Point(1024, 243);
            m1[15] = new Point(1103, 311);
            m1[16] = new Point(1100, 293);
            m1[17] = new Point(1136, 306);
            m1[18] = new Point(1130, 279);
            m1[19] = new Point(1139, 283);
            m1[20] = new Point(1113, 234);
            m1[21] = new Point(1197, 255);

            m1[22] = new Point(1280, 720);

            g.FillPolygon(mo1, m1);


            //Горы 2
            Point[] m2 = new Point[31];

            m2[30] = new Point(0, 720);

            m2[0] = new Point(0, 276);
            m2[1] = new Point(52, 212);
            m2[2] = new Point(48, 306);
            m2[3] = new Point(165, 265);
            m2[4] = new Point(209, 336);
            m2[5] = new Point(352, 170);
            m2[6] = new Point(316, 283);
            m2[7] = new Point(316, 283);
            m2[8] = new Point(327, 340);
            m2[9] = new Point(504, 82);
            m2[10] = new Point(435, 371);
            m2[11] = new Point(481, 348);
            m2[12] = new Point(475, 428);
            m2[13] = new Point(516, 415);
            m2[14] = new Point(520, 506);
            m2[15] = new Point(718, 571);
            
            m2[16] = new Point(645, 472);
            m2[17] = new Point(662, 433);
            m2[18] = new Point(677, 445);
            m2[19] = new Point(680, 423);
            m2[20] = new Point(722, 427);
            m2[21] = new Point(721, 300);
            m2[22] = new Point(805, 376);
            m2[23] = new Point(796, 343);
            m2[24] = new Point(855, 378);
            m2[25] = new Point(863, 350);
            m2[26] = new Point(939, 323);
            m2[27] = new Point(911, 277);
            m2[28] = new Point(1280, 387);

            m2[29] = new Point(1280, 720);

            g.FillPolygon(mo2, m2);

            //Горы 3.1
            Point[] m3 = new Point[24];

            m3[0] = new Point(0, 430);
            
            m3[12] = new Point(208,511);
            m3[13] = new Point(190, 439);
            m3[14] = new Point(141, 492);
            m3[15] = new Point(122, 472);
            m3[16] = new Point(107, 477);
            m3[17] = new Point(128, 391);
            m3[18] = new Point(56, 445);
            m3[19] = new Point(49, 427);
            m3[20] = new Point(32, 437);
            m3[21] = new Point(30, 423);
            m3[22] = new Point(14, 427);
            m3[23] = new Point(14, 411);

            g.FillPolygon(mo3, m3);

            //Горы 4
            Point[] m4 = new Point[18];

            m4[0] = new Point(211, 510);
            m4[1] = new Point(234, 480);
            m4[2] = new Point(265, 505);
            m4[3] = new Point(315, 467);
            m4[4] = new Point(394, 517);
            m4[5] = new Point(422, 494);
            m4[6] = new Point(725, 577);
            m4[7] = new Point(617, 531);
            m4[8] = new Point(666, 496);
            m4[9] = new Point(693, 533);
            m4[10] = new Point(794, 510);
            m4[11] = new Point(845, 527);
            m4[12] = new Point(890, 642);
            m4[13] = new Point(583, 650);
            m4[14] = new Point(446, 649);
            m4[15] = new Point(429, 612);
            m4[16] = new Point(354, 598);
            m4[17] = new Point(341, 556);

            g.FillPolygon(mo4, m4);

            //Горы 3.2
            Point[] m3 = new Point[11];

            m3[0] = new Point(889, 642);

            m3[5] = new Point(1110, 469);
            m3[6] = new Point(1088, 445);
            m3[7] = new Point(1032, 630);
            m3[8] = new Point(1009, 652);
            m3[9] = new Point(926, 654);
            m3[10] = new Point(902, 636);

            g.FillPolygon(mo3, m3);

            //Горы 5.1
            Point[] m51 = new Point[25];

            m51[0] = new Point(0, 475);
            m51[1] = new Point(110, 601);
            m51[2] = new Point(112, 575);
            m51[3] = new Point(137, 583);
            m51[4] = new Point(154, 533);
            m51[5] = new Point(218, 657);
            m51[6] = new Point(231, 584);
            m51[7] = new Point(293, 662);
            m51[8] = new Point(346, 631);
            m51[9] = new Point(560, 720);

            m51[10] = new Point(652, 720);
            m51[11] = new Point(661, 695);
            m51[12] = new Point(688, 709);
            m51[13] = new Point(706, 625);
            m51[14] = new Point(808, 720);
            m51[15] = new Point(808, 720);

            m51[16] = new Point(879, 720);
            m51[17] = new Point(893, 705);
            m51[18] = new Point(938, 720);

            m51[19] = new Point(1000, 720);
            m51[20] = new Point(1087, 440);
            m51[21] = new Point(1112, 470);
            m51[22] = new Point(1280, 42);
            m51[23] = new Point(1280, 720);
            m51[24] = new Point(0, 720);

            g.FillPolygon(mo1, m51);

            mo1.Dispose();
            mo2.Dispose();
            mo3.Dispose();
            mo4.Dispose();*/

            g.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { DrawSky(); } 
            
        private void Form1_Resize(object sender, EventArgs e)
        {   DrawSky();  }
    }
}
