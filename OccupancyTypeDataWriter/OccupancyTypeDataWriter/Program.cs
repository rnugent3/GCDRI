// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> occTypeFile = new List<string>();

for (int i = 0; i < 100000; i++)
{
    string occType = "";
    occType += $"RES{i} - 1SNB One Story No Basement - EGM 01-03	RES	Stage	-2	-1	0	1	2	3	4	5	6	7	8	9	10	11	12	13	14	15	16							" + Environment.NewLine;
    occType += $"RES{i}-1SNB			S 	0	2.5	13.4	23.3	32.1	40.1	47.1	53.2	58.6	63.2	67.2	70.5	73.2	75.4	77.2	78.5	79.5	80.2	80.7							" + Environment.NewLine;
    occType += $"RES{i} -1SNB			SN	0	2.7	2	1.6	1.6	1.8	1.9	2	2.1	2.2	2.3	2.4	2.7	3	3.3	3.7	4.1	4.5	4.9							" + Environment.NewLine;
    occType += $"RES{i} -1SNB			Stage	-2	-1	0	1	2	3	4	5	6	7	8	9	10	11	12	13	14	15	16							" + Environment.NewLine;
    occType += $"RES{i} -1SNB			C 	0	2.4	8.1	13.3	17.9	22	25.7	28.8	31.5	33.8	35.7	37.2	38.4	39.2	39.7	40	40.1	40.2	40.3							" + Environment.NewLine;
    occType += $"RES{i} -1SNB			CN	0	2.1	1.5	1.2	1.2	1.4	1.5	1.6	1.6	1.7	1.8	1.9	2.1	2.3	2.6	2.9	3.2	3.5	3.8							" + Environment.NewLine;
    occType += $"RES{i} -1SNB			Struct	N		0.5		T		35.71	128.57	N	100	0		 	-901			 	-901	" + Environment.NewLine;
    occTypeFile.Add(occType);
}

string filePath = @"C:\Temp\OccTypes.txt";
File.AppendAllLines(filePath, occTypeFile);
