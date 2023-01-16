using Omega_Sudoku;
using Omega_Sudoku.IO;

namespace SudokuTest
{
    public class SudokuUnitTest
    {
        [Fact]
        public void TestEmpty9x9()
        {
            SudokuSolver solver = new SudokuSolver();
            solver.Wrapper(null, null, "000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Assert.Equal("123456789456789123789123456231674895875912364694538217317265948542897631968341572",
                solver.Solve());
        }
        [Fact]
        public void TestEmpty16x16()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = "";
            for (int i = 0; i < Math.Pow(16, 2); i++)
            {
                input += "0";
            }
            solver.Wrapper(null, null, input);
            Assert.Equal("123456789:;<=>?@5678=>?@12349:;<9:;<1234=>?@5678=>?@9:;<56781234241389:5>;<6@?=7?;<>@4162=57839:7=@9>;2?83:164<585:637<=?@49;12>31826597;4@=:<>?<74=;?>1398:2@56>@9:4<=2651?378;6?5;:8@37<2>491=4861<35;:7>2?=@9:3=?7@89<165>;42;<>52=4:@?937861@927?16>48=;<5:3",
                solver.Solve());
        }
        [Fact]
        public void TestEmpty25x25()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = "";
            for (int i = 0; i < Math.Pow(25, 2); i++)
            {
                input += "0";
            }
            solver.Wrapper(null, null, input);
            Assert.Equal("123456789:;<=>?@ABCDEFGHI6789:EFGHI12345;<=>?@ABCD;<=>?12345@ABCDEFGHI6789:@ABCD;<=>?EFGHI6789:12345EFGHI@ABCD6789:12345;<=>?25134:;<=6BE>?7FGC@8IHDA9ADEFGH>517I3689<=;?2:@4BC:@C69?GEI4F=<DH>BA137528;HI><B28A@F4C;:G79D563=1?E8?7;=CD93B215A@H:EI4<>6FG31?@2>9CA8=DFE4:57BGH;I<6FGHDC456<1?B@;3I>28=9:E7AI4A8<=@7B2>9:56?HF;EDGC13=>5E;FH:D37GI1CA496<28?@B7:9B6GI?E;H8A2<CD13@=4>5F4;25>9=16E<:7GA3C?DHFB@I89=:7FB3>2G5?D@148IEAC6<;H?C@IH84DFA3;E62B1:<>G95=7B36G1<:@7C8IH=>2;5F9?DAE4<8DAE5?I;H94CBF=6@G7>1:3256F:3AB28=D>1I;9?<7C4EHG@>B418DCF?9AH23EG@6=;5I7:<C9;=@I14G<:6?785EH2BA3FD>DEI?A76H5>G@9<=834:FBC;21GH<273E;:@C54FBDI>A18?96=",
                solver.Solve());
        }
        [Fact]
        public void Test4x4Basic()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = "1200340000000000";
            solver.Wrapper(null, null, input);
            Assert.Equal("1234341221434321",
                solver.Solve());
        }
        
        [Fact]
        public void Test9x9Basic()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = "120034000000000000000000000000000000000000000000000000000000000000000000000000000";
            solver.Wrapper(null, null, input);
            Assert.Equal("125634789346789125789125346261573894537498261498216537652341978813967452974852613",
                solver.Solve());
        }
        [Fact]
        public void Test9X9Intermidiate()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = "005807600020000007800020000510000209600105080004092003000008906000010000000060050";
            solver.Wrapper(null, null, input);
            Assert.Equal("135847692926351847847926135513784269692135784784692513351478926269513478478269351",
                solver.Solve());
        }

        [Fact]
        public void Test25X25Unsolvable()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = "0;0G0H00E4?=<0030DF000007097@A8000G0H:0E200<00BD05BD003@0000C0060IE4H:12?000?0<1500DF90@006;CG80000HIE400<000=0F00BA007@86000:0E4H0<10?00F03@0>00G000C06;000H0IE2?=00030D07@A00A>0700860000H:I120=<0000F300F500009;0000:0E40<10?00200<F5000000@0800C00:IE400000D05000>070G86000H:I000IE0?=0103BD007@009C080;G860004H:010?=<0030D970A>0A0970000;I0400<020=F500D50B0F0000>60C0800IE4=<00?F00BD>97@A06;CG40000?=<120<02?00000@A090CG86;000:I4000E00=0100B0F000A>;0000CG0000E4H:<12?0DF00B>00@070A00;0G060I04H0<0000F53B00@0>00CG0H:0E0?00020D050D003BA>070G86;004H002?=<10=<020B0F570A09;CG86I00H:E00:I00?00F500D>90@06;008;C086:0E4000020B0F530>90G";
            solver.Wrapper(null, null, input);
            Assert.Throws<IllegalBoardException>(() => solver.Solve());
        }
        [Fact]
        public void Test16X16Unsolvable()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = ";0?0=>010690000000710000500:?0;4000000<0400070=005<3000800000000500@000:?80>10004<30>?8;00=20000>?8;270060000000000000900000000?0000?00000>0=000?3:0000>0026000000;>61029@0<00000100<0@00:40000800500:0?;>012600800?0;0000090<0@0;07000005<00?8:00003050:4080709";
            solver.Wrapper(null, null, input);
            Assert.Throws<IllegalBoardException>(() => solver.Solve());
        }
        [Fact]
        public void Test9X9Unsolvable()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = ";0?0=>010690000000710000500:?0;4000000<0400070=005<3000800000000500@000:?80>10004<30>?8;00=20000>?8;270060000000000000900000000?0000?00000>0=000?3:0000>0026000000;>61029@0<00000100<0@00:40000800500:0?;>012600800?0;0000090<0@0;07000005<00?8:00003050:4080709";
            solver.Wrapper(null, null, input);
            Assert.Throws<IllegalBoardException>(() => solver.Solve());
        }

        [Fact]
        public void TestEmptyBoard()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = "";
            Assert.Throws<IllegalBoardSize>(() => solver.Wrapper(null, null, input));
        }
        [Fact]
        public void TestBoardSize()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = "0210";
            Assert.Throws<IllegalBoardSize>(() => solver.Wrapper(null, null, input));
        }
        [Fact]
        public void TestBoardCharacter()
        {
            SudokuSolver solver = new SudokuSolver();
            string input = "005807600020000007800020000510000209600105080j04092003000008906000010000000060050";
            Assert.Throws<IllegalBoardCharacter>(() => solver.Wrapper(null, null, input));
        }
    }
}