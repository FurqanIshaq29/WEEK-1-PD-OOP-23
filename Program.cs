using System;

public static class GlobalMembers
{
	public static void generatecolours()
	{
		char i;
		for (i = 0; i < 256; i++)
		{
			Console.Write(i);
			Console.Write("\n");
		}
	}

	public static void generateColors()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		// you can loop k higher to see more color choices
		for (int k = 1; k < 255; k++)
		{
			// pick the colorattribute k you want
			SetConsoleTextAttribute(hConsole, k);
			Console.Write(k);
			Console.Write(" Try to give your Best!");
			Console.Write("\n");
		}
	}

	static int Main()
	{
		generatecolours();
		// generateColors();
	}

	public static void generateCharacters()
	{
		char character;
		for (int x = 0; x < 256; x++)
		{
			// pick the characters combinations to make your players and enemies
			character = x;
			Console.Write(character);
			Console.Write("\n");
		}
	}

	public static void generateColors()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		// you can loop k higher to see more color choices
		for (int k = 1; k < 255; k++)
		{
			// pick the colorattribute k you want
			SetConsoleTextAttribute(hConsole, k);
			Console.Write(k);
			Console.Write(" Try to give your Best!");
			Console.Write("\n");
		}
	}

	static int Main()
	{

		char box3 = 3;

		Console.Write(box3);
		Console.Write("\n");

		generateCharacters();
		generateColors();
	}

	public static void printMaze()
	{
		Console.Write("%%%%%%%%%%%%%%%%%%%%%%%%%");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%                       %");
		Console.Write("\n");
		Console.Write("%%%%%%%%%%%%%%%%%%%%%%%%%");
		Console.Write("\n");

	}

	public static void gotoxy(int x, int y)
	{
		COORD coordinate = new COORD();
		coordinate.X = x;
		coordinate.Y = y;
		SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinate);
	}

	public static void printPacman(int x, int y)
	{
		gotoxy(x, y);
		Console.Write("p");
	}

	public static char getcharatxy(short x, short y)
	{
		CHAR_INFO ci = new CHAR_INFO();
		COORD xy = new COORD(0, 0);
		SMALL_RECT rect = new SMALL_RECT(x, y, x, y);
		COORD coordbufsize = new COORD();
		coordbufsize.X = 1;
		coordbufsize.Y = 1;
		return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), ci, coordbufsize, xy, rect) ? ci.Char.AsciiChar : ' ';
	}

	public static void erase(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	static int Main()
	{
		int pX = 4;
		int pY = 4;

		system("cls");
		printMaze();

		printPacman(pX, pY);

		while (true)
		{
			if (GetAsyncKeyState(VK_LEFT))
			{
				char nextLocation = getcharatxy((short)(pX - 1), (short)pY);
				if (nextLocation == ' ')
				{
					erase(pX, pY);
					pX = pX - 1;
					printPacman(pX, pY);
				}
			}

			if (GetAsyncKeyState(VK_RIGHT))
			{
				char nextLocation = getcharatxy((short)(pX + 1), (short)pY);
				if (nextLocation == ' ')
				{
					erase(pX, pY);
					pX = pX + 1;
					printPacman(pX, pY);
				}
			}

			if (GetAsyncKeyState(VK_UP))
			{
				char nextLocation = getcharatxy((short)pX, (short)(pY - 1));
				if (nextLocation == ' ')
				{
					erase(pX, pY);
					pY = pY - 1;
					printPacman(pX, pY);
				}
			}

			if (GetAsyncKeyState(VK_DOWN))
			{
				char nextLocation = getcharatxy((short)pX, (short)(pY + 1));
				if (nextLocation == ' ')
				{
					erase(pX, pY);
					pY = pY + 1;
					printPacman(pX, pY);
				}
			}

			if (GetAsyncKeyState(VK_ESCAPE))
			{
				return 0;

			}
			Sleep(200);
		}
	}

	public static char box2 = 177;
	public static char a = 219;
	static int Main()
	{
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("                                                                                             ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("      ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("                                                                                             ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");

	}
	static int Main()
	{
		char box = 219;
		char arrray[1] = { 'box' }; cout << arrray[0];
	}




	/* char character1[5] = {' ', ' ', '^', ' ', ' '};
	    char character2[5] = {' ', '|', ' ', '|', ' '};
	    char character3[5] = {'box', 'box', ' ', 'box', 'box'};
	    char character4[5] = {'box', 'box', ' ', 'box', 'box'};
	    char character5[5] = {' ', '|', ' ', '|', ' '};*/
	public static void bulletCollisionWithEnemyRight()

	{
		for (int x = 0; x < bulletCountRight; x++)
		{
			if (bulletRightX[x] + 1 == e1nemyX && (bulletRightY[x] == e1nemyY || bulletRightY[x] == e1nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
			}

			if (bulletRightX[x] + 1 == e2nemyX && (bulletRightY[x] == e2nemyY || bulletRightY[x] == e2nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
			}
			if (bulletRightX[x] + 1 == e3nemyX && (bulletRightY[x] == e3nemyY || bulletRightY[x] == e3nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
			}
			if (bulletRightX[x] + 1 == e4nemyX && (bulletRightY[x] == e4nemyY || bulletRightY[x] == e4nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
			}
		}
		//------------------Collision woth the Player
		public static void bulletCollisionWithPlayerRightEnemy1()

		{
			for (int x = 0; x < bulletCountRightEnemy1; x++)
			{
				if (enemy1BulletRightX[x] + 1 == pX && (enemy1BulletRightY[x] == pY || enemy1BulletRightY[x] == pY + 1 || enemy1BulletRightY[x] == pY + 2))
				{
					healthCounter--;
					eraseBulletRightEnemy1(enemy1BulletRightX[x], enemy1BulletRightY[x]);
					removeBulletfromArrayRightEnemy1(x);
				}
			}
		}
		public static void bulletCollisionWithPlayerRightEnemy2()
		{
			for (int x = 0; x < bulletCountRightEnemy2; x++)
			{
				if (enemy2BulletRightX[x] + 1 == pX && (enemy2BulletRightY[x] == pY || enemy2BulletRightY[x] == pY + 1 || enemy2BulletRightY[x] == pY + 2))
				{
					healthCounter--;
					eraseBulletRightEnemy2(enemy2BulletRightX[x], enemy2BulletRightY[x]);
					removeBulletfromArrayRightEnemy2(x);
				}
			}
		}
		public static void bulletCollisionWithPlayerRightEnemy3()
		{
			for (int x = 0; x < bulletCountRightEnemy3; x++)

			{
				if (enemy3BulletRightX[x] + 1 == pX && (enemy3BulletRightY[x] == pY || enemy3BulletRightY[x] == pY + 1 || enemy3BulletRightY[x] == pY + 2))
				{
					healthCounter--;
					eraseBulletRightEnemy3(enemy3BulletRightX[x], enemy3BulletRightY[x]);
					removeBulletfromArrayRightEnemy3(x);
				}
			}
		}
		public static void bulletCollisionWithPlayerRightEnemy4()
		{
			for (int x = 0; x < bulletCountRightEnemy4; x++)

			{
				if (enemy4BulletRightX[x] + 1 == pX && (enemy4BulletRightY[x] == pY || enemy4BulletRightY[x] == pY + 1 || enemy4BulletRightY[x] == pY + 2))
				{
					healthCounter--;

					eraseBulletRightEnemy4(enemy4BulletRightX[x], enemy4BulletRightY[x]);
					removeBulletfromArrayRightEnemy4(x);
				}
			}
		}

		public static void storeCharacterCoordinate()
		{
			fstream file = new fstream();
			file.open("CharacterInfo.txt", ios.@out);
			file << pX << "\n";
			file << pY << "\n";
			file.close();
		}

		public static void LoadCoordinate()
		{
			fstream file = new fstream();
			int px;
			int py;
			file.open("CharacterInfo.txt", ios.@in);
			while (file.eof())
			{
				px = pX;
				py = pY;
			}
			file.close();
		}

	public static IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	public static void healthDecrement()
	{
		char next = getcharatxy((short)(pX - 1), (short)pY);
		char next1 = getcharatxy((short)(pX + 5), (short)pY);
		char next2 = getcharatxy((short)(pX - 1), (short)(pY + 1));
		char next3 = getcharatxy((short)(pX + 5), (short)(pY + 1));
		if (next == (char)15 || next1 == (char)15 || next2 == (char)15 || next3 == (char)15)
		{
			healthCounter--;
		}
	}

	//            functions prototypes
	public static void printMaze()
	{
		// 87
		SetConsoleTextAttribute(hConsole, 3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("                                                                                                                        ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                   ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                                   ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                     ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("     ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("           ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("     ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                           ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("     ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                           ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("                                                                                                                        ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("             ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                                                                                        ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("              ");
		Console.Write(box1);
		Console.Write("               ");
		Console.Write(box1);
		Console.Write("                                  Health :                          STATUS :             ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("              ");
		Console.Write(box1);
		Console.Write("               ");
		Console.Write(box1);
		Console.Write("                                                                                         ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("             ");
		Console.Write(box2);
		Console.Write(box1);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box1);
		Console.Write(box2);
		Console.Write("                                                                                        ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("              ");
		Console.Write(box1);
		Console.Write("               ");
		Console.Write(box1);
		Console.Write("                                                                                         ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write("\n");
	}

	public static void gotoxy(int x, int y)
	{
		COORD coordinate = new COORD();
		coordinate.X = x;
		coordinate.Y = y;
		SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinate);
	}

	public static char getcharatxy(short x, short y)
	{
		CHAR_INFO ci = new CHAR_INFO();
		COORD xy = new COORD(0, 0);
		SMALL_RECT rect = new SMALL_RECT(x, y, x, y);
		COORD coordbufsize = new COORD();
		coordbufsize.X = 1;
		coordbufsize.Y = 1;
		return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), ci, coordbufsize, xy, rect) ? ci.Char.AsciiChar : ' ';
	}

	//  -------------------print the main character

	public static void printCharacter()
	{
		SetConsoleTextAttribute(hConsole, 1);

		gotoxy(pX, pY);

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character1[i]);
		}
		gotoxy(pX, pY + 1);

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character2[i]);
		}
		gotoxy(pX, pY + 2);

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character3[i]);
		}
	}

	//---------------------Erase the main character

	public static void eraseCharacter()
	{
		gotoxy(pX, pY);
		for (int i = 0; i < 5; i++)
		{
			Console.Write(" ");
		}
		gotoxy(pX, pY + 1);
		for (int i = 0; i < 5; i++)
		{
			Console.Write(" ");
		}
		gotoxy(pX, pY + 2);
		for (int i = 0; i < 5; i++)
		{
			Console.Write(" ");
		}
	}

	// Generates the lift # 1

	public static void generateLift1()
	{
		SetConsoleTextAttribute(hConsole, 7);

		int x = 36;
		int y = 7;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 2

	public static void generateLift2()
	{
		SetConsoleTextAttribute(hConsole, 7);

		int x = 81;
		int y = 7;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 3

	public static void generateLift3()
	{
		SetConsoleTextAttribute(hConsole, 7);

		int x = 51;
		int y = 14;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 4

	public static void generateLift4()
	{
		SetConsoleTextAttribute(hConsole, 7);

		int x = 67;
		int y = 14;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 5

	public static void generateLift5()
	{
		SetConsoleTextAttribute(hConsole, 7);

		int x = 33;
		int y = 21;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 6

	public static void generateLift6()
	{
		SetConsoleTextAttribute(hConsole, 7);

		int x = 84;
		int y = 21;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 7

	public static void generateLift7()
	{
		SetConsoleTextAttribute(hConsole, 7);

		int x = 59;
		int y = 28;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	//------------------------Move Mario Left

	public static void moveMarioLeft()
	{
		char next1 = getcharatxy((short)(pX - 1), (short)pY);
		char next2 = getcharatxy((short)(pX - 1), (short)(pY + 1));
		char next3 = getcharatxy((short)(pX - 1), (short)(pY + 2));
		char next4 = getcharatxy((short)(pX - 1), (short)(pY + 3));

		if (((next1 == ' ' && next2 == ' ' && next3 == ' ') || (next1 == '|' && next2 == '|' && next3 == '|') || (next1 == lift && next2 == lift && next3 == lift && next3 == lift)) && (next4 != ' '))
		{
			eraseCharacter();
			pX = pX - 1;
			printCharacter();
		}
		if (next1 == enemyBulletName || next2 == enemyBulletName || next3 == enemyBulletName || next4 == enemyBulletName)
		{
			healthCounter--;
		}
	}

	//------------------------Move Mario Right

	public static void moveMarioRight()
	{
		char next1 = getcharatxy((short)(pX + 5), (short)pY);
		char next2 = getcharatxy((short)(pX + 5), (short)(pY + 1));
		char next3 = getcharatxy((short)(pX + 5), (short)(pY + 2));
		char next4 = getcharatxy((short)(pX + 5), (short)(pY + 3));
		if (((next1 == ' ' && next2 == ' ' && next3 == ' ') || (next1 == '|' && next2 == '|' && next3 == '|') || (next1 == lift && next2 == lift && next3 == lift && next3 == lift)) && (next4 != ' '))
		{
			eraseCharacter();
			pX = pX + 1;
			printCharacter();
		}
		if (next1 == enemyBulletName || next2 == enemyBulletName || next3 == enemyBulletName || next4 == enemyBulletName)
		{
			healthCounter--;
		}
	}

	//------------------------Move Mario Up

	public static void moveMarioUp()
	{
		char next1 = getcharatxy((short)pX, (short)(pY - 1));
		char next2 = getcharatxy((short)(pX + 1), (short)(pY - 1));
		char next3 = getcharatxy((short)(pX + 2), (short)(pY - 1));
		char next4 = getcharatxy((short)(pX + 3), (short)(pY - 1));
		char next5 = getcharatxy((short)(pX + 4), (short)(pY - 1));
		char next6 = getcharatxy((short)(pX + 5), (short)pY);
		char next7 = getcharatxy((short)(pX - 1), (short)pY);
		char next8 = getcharatxy((short)(pX + 5), (short)(pY + 1));
		char next9 = getcharatxy((short)(pX - 1), (short)(pY + 1));
		char next10 = getcharatxy((short)(pX + 5), (short)(pY + 2));
		char next11 = getcharatxy((short)(pX - 1), (short)(pY + 2));
		if ((next1 == '|' && next2 == lift && next3 == lift && next4 == lift && next5 == '|') || (next6 == box1 || next7 == box1) || (next8 == box1 || next9 == box1) || (next10 == box1 || next11 == box1))

		{
			eraseCharacter();
			pY = pY - 1;
			printCharacter();
		}
	}

	//------------------------Move Mario Down

	public static void moveMarioDown()
	{
		char next1 = getcharatxy((short)pX, (short)(pY + 3));
		char next2 = getcharatxy((short)(pX + 1), (short)(pY + 3));
		char next3 = getcharatxy((short)(pX + 2), (short)(pY + 3));
		char next4 = getcharatxy((short)(pX + 3), (short)(pY + 3));
		char next5 = getcharatxy((short)(pX + 4), (short)(pY + 3));

		if ((next1 == '|' && next2 == lift && next3 == lift && next4 == lift && next5 == '|'))
		{
			eraseCharacter();
			pY = pY + 1;
			printCharacter();
		}
	}
	//-----------moveEnemy1


	public static void moveEnemy1()
	{
		if (enemyDirection1 == "Right")
		{
			char next = getcharatxy((short)(e1nemyX + 6), (short)e1nemyY);
			char next1 = getcharatxy((short)(e1nemyX + 6), (short)(e1nemyY + 2));
			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy1();
				e1nemyX++;
				printEnemy1(e1nemyX);
			}
			if (next1 == ' ')

			{
				enemyDirection1 = "Left";
			}
			generateBulletEnemy1Right();
		}

		if (enemyDirection1 == "Left")
		{
			char next = getcharatxy((short)(e1nemyX - 1), (short)e1nemyY);
			char next1 = getcharatxy((short)(e1nemyX - 1), (short)(e1nemyY + 2));
			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy1();
				e1nemyX--;
				printEnemy1(e1nemyX);
			}
			if (next1 == ' ')
			{
				enemyDirection1 = "Right";
			}
			generateBulletEnemy1Left();
		}
	}

	//-----------moveEnemy2


	public static void moveEnemy2()
	{
		if (enemyDirection2 == "Right")
		{
			char next = getcharatxy((short)(e2nemyX + 6), (short)e2nemyY);
			char next1 = getcharatxy((short)(e2nemyX + 6), (short)(e2nemyY + 2));
			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))

			{
				eraseEnemy2();
				e2nemyX++;
				printEnemy2(e2nemyX);
			}
			if (next != ' ')
			{
				enemyDirection2 = "Left";
			}
			generateBulletEnemy2Right();
		}

		if (enemyDirection2 == "Left")
		{
			char next = getcharatxy((short)(e2nemyX - 1), (short)e2nemyY);
			char next1 = getcharatxy((short)(e2nemyX - 1), (short)(e2nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy2();
				e2nemyX--;
				printEnemy2(e2nemyX);
			}
			if (next != ' ')
			{
				enemyDirection2 = "Right";
			}
			generateBulletEnemy2Left();
		}
	}

	//-----------moveEnemy3


	public static void moveEnemy3()
	{
		if (enemyDirection3 == "Right")
		{
			char next = getcharatxy((short)(e3nemyX + 6), (short)e3nemyY);
			char next1 = getcharatxy((short)(e3nemyX + 6), (short)(e3nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy3();
				e3nemyX++;
				printEnemy3(e3nemyX);
			}
			if (next != ' ')
			{
				enemyDirection3 = "Left";
			}
			generateBulletEnemy3Right();
		}

		if (enemyDirection3 == "Left")
		{
			char next = getcharatxy((short)(e3nemyX - 1), (short)e3nemyY);
			char next1 = getcharatxy((short)(e3nemyX - 1), (short)(e3nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))

			{
				eraseEnemy3();
				e3nemyX--;
				printEnemy3(e3nemyX);
			}
			if (next != ' ')
			{
				enemyDirection3 = "Right";
			}
			generateBulletEnemy3Left();
		}
	}

	//-----------moveEnemy4


	public static void moveEnemy4()
	{
		if (enemyDirection4 == "Right")
		{
			char next = getcharatxy((short)(e4nemyX + 6), (short)e4nemyY);
			char next1 = getcharatxy((short)(e4nemyX + 6), (short)(e4nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy4();
				e4nemyX++;
				printEnemy4(e4nemyX);
			}
			if (next != ' ')
			{
				enemyDirection4 = "Left";
			}
			generateBulletEnemy4Right();
		}

		if (enemyDirection4 == "Left")
		{
			char next = getcharatxy((short)(e4nemyX - 1), (short)e4nemyY);
			char next1 = getcharatxy((short)(e4nemyX - 1), (short)(e4nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))

			{
				eraseEnemy4();
				e4nemyX--;
				printEnemy4(e4nemyX);
			}
			if (next != ' ')
			{
				enemyDirection4 = "Right";
			}
			generateBulletEnemy4Left();
		}
	}

	//--------------------Print Enemy 1


	public static void printEnemy1(int e1nemyX)
	{
		SetConsoleTextAttribute(hConsole, 4);
		gotoxy(e1nemyX, e1nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy1[index]);
		}
		gotoxy(e1nemyX, e1nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy2[index]);
		}
	}

	//--------------------Print Enemy 2


	public static void printEnemy2(int e2nemyX)
	{
		SetConsoleTextAttribute(hConsole, 4);

		gotoxy(e2nemyX, e2nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy1[index]);
		}
		gotoxy(e2nemyX, e2nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy2[index]);
		}
	}

	//--------------------Print Enemy 3


	public static void printEnemy3(int e3nemyX)
	{
		SetConsoleTextAttribute(hConsole, 4);

		gotoxy(e3nemyX, e3nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e3nemy1[index]);
		}
		gotoxy(e3nemyX, e3nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e3nemy2[index]);
		}
	}

	//--------------------Print Enemy 4


	public static void printEnemy4(int e4nemyX)
	{
		SetConsoleTextAttribute(hConsole, 4);

		gotoxy(e4nemyX, e4nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e4nemy1[index]);
		}
		gotoxy(e4nemyX, e4nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e4nemy2[index]);
		}
	}

	//-----------erase enemy1

	public static void eraseEnemy1()
	{
		gotoxy(e1nemyX, e1nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e1nemyX, e1nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	//-----------erase enemy2

	public static void eraseEnemy2()
	{
		gotoxy(e2nemyX, e2nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e2nemyX, e2nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	//-----------erase enemy3

	public static void eraseEnemy3()
	{
		gotoxy(e3nemyX, e3nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e3nemyX, e3nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	//-----------erase enemy 4

	public static void eraseEnemy4()
	{
		gotoxy(e4nemyX, e4nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e4nemyX, e4nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	//-----------------------Generates the bullet of the main character to RIGHTTTTT


	public static void generateBulletRight()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		char bulletRight = 16;
		bulletRightX[bulletCountRight] = pX + 5;
		bulletRightY[bulletCountRight] = pY + 1;
		char next = getcharatxy((short)(pX + 5), (short)(pY + 1));
		if (next == ' ')

		{
			gotoxy(pX + 5, pY + 1);
			Console.Write(bulletRight);
			bulletCountRight++;
		}
	}

	public static void moveBulletRight()
	{
		for (int x = 0; x < bulletCountRight; x++)
		{
			char next = getcharatxy((short)(bulletRightX[x] + 1), (short)bulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
			}
			else
			{
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				bulletRightX[x] = bulletRightX[x] + 1;
				printBulletRight(bulletRightX[x], bulletRightY[x]);
			}
		}
	}

	public static void eraseBulletRight(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void printBulletRight(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		char bulletRight = 16;
		gotoxy(x, y);
		Console.Write(bulletRight);
	}

	public static void removeBulletfromArrayRight(int index)
	{
		for (int x = index; x < bulletCountRight - 1; x++)
		{
			bulletRightX[x] = bulletRightX[x + 1];
			bulletRightY[x] = bulletRightY[x + 1];
		}
		bulletCountRight--;
	}

	//------------------Collision woth the enemy

	public static void bulletCollisionWithEnemyRight()

	{
		for (int x = 0; x < bulletCountRight; x++)
		{
			if (bulletRightX[x] + 1 == e1nemyX && (bulletRightY[x] == e1nemyY || bulletRightY[x] == e1nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
				enemy1Health--;
			}

			if (bulletRightX[x] + 1 == e2nemyX && (bulletRightY[x] == e2nemyY || bulletRightY[x] == e2nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
				enemy2Health--;
			}
			if (bulletRightX[x] + 1 == e3nemyX && (bulletRightY[x] == e3nemyY || bulletRightY[x] == e3nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
				enemy3Health--;
			}
			if (bulletRightX[x] + 1 == e4nemyX && (bulletRightY[x] == e4nemyY || bulletRightY[x] == e4nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
				enemy4Health--;
			}
		}
	}

	//---------move bullet Left------------------------------------------------------------------------------------------------------------

	public static void generateBulletLeft()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		char bulletLeft = 17;
		bulletLeftX[bulletCountLeft] = pX - 1;
		bulletLeftY[bulletCountLeft] = pY + 1;
		char next = getcharatxy((short)(pX - 1), (short)(pY + 1));
		if (next == ' ')
		{
			gotoxy(pX - 1, pY + 1);
			Console.Write(bulletLeft);
			bulletCountLeft++;
		}
	}

	public static void moveBulletLeft()
	{
		for (int x = 0; x < bulletCountLeft; x++)
		{
			char next = getcharatxy((short)(bulletLeftX[x] - 1), (short)bulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
			}
			else
			{
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				bulletLeftX[x] = bulletLeftX[x] - 1;
				printBulletLeft(bulletLeftX[x], bulletLeftY[x]);
			}
		}
	}

	public static void eraseBulletLeft(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void printBulletLeft(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		char bulletLeft = 17;
		gotoxy(x, y);
		Console.Write(bulletLeft);
	}

	public static void removeBulletfromArrayLeft(int index)
	{
		for (int x = index; x < bulletCountLeft - 1; x++)
		{
			bulletLeftX[x] = bulletLeftX[x + 1];
			bulletLeftY[x] = bulletLeftY[x + 1];
		}
		bulletCountLeft--;
	}

	//------------------Collision with the enemy Left---------------------------------

	public static void bulletCollisionWithEnemyLeft()

	{
		for (int x = 0; x < bulletCountLeft; x++)
		{
			if (bulletLeftX[x] - 1 == e1nemyX + 5 && (bulletLeftY[x] == e1nemyY || bulletLeftY[x] == e1nemyY + 1))
			{
				addScore();
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
				enemy1Health--;
			}

			if (bulletLeftX[x] - 1 == e2nemyX + 5 && (bulletLeftY[x] == e2nemyY || bulletLeftY[x] == e2nemyY + 1))
			{
				addScore();
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
				enemy2Health--;
			}
			if (bulletLeftX[x] - 1 == e3nemyX + 5 && (bulletLeftY[x] == e3nemyY || bulletLeftY[x] == e3nemyY + 1))
			{
				addScore();
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
				enemy3Health--;
			}
			if (bulletLeftX[x] - 1 == e4nemyX + 5 && (bulletLeftY[x] == e4nemyY || bulletLeftY[x] == e4nemyY + 1))
			{
				addScore();
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
				enemy4Health--;
			}
		}
	}

	public static string loginOption;

	// game Entrance
	public static void gameEntrance()
	{
		Console.Write("                                                                                                      ");
		Console.Write("\n");
		Console.Write("                                                                                                      ");
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                                                                                                      ");
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
	}

	// top header displays at the top

	public static void topHeader()
	{
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("                                                                                             ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("      ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("                                                                                             ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
	}

	// login menu

	public static string loginMenu()
	{
		string option;
		Console.Write("\n\n\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");
		Console.Write("1. Start the game\n");
		Console.Write("2. Instructions\n");
		Console.Write("3. Character Information\n");
		Console.Write("4. Exit the game\n\n\n");
		Console.Write("Choose your Option......  ");
		option = ConsoleInput.ReadToWhiteSpace(true);
		return option;
	}

	// menu 1 of the game the main working of the game

	public static void menu1()
	{
		bool isGameRunning = true;
		system("cls");
		printMaze();
		printCharacter();
		LoadCoordinate();

		while (isGameRunning == true && healthCounter > 0)
		{
			healthDecrement();
			printScore();
			if (GetAsyncKeyState(VK_LEFT))
			{
				moveMarioLeft();
			}
			if (GetAsyncKeyState(VK_RIGHT))
			{
				moveMarioRight();
			}

			if (GetAsyncKeyState(VK_UP))
			{
				moveMarioUp();
			}

			if (GetAsyncKeyState(VK_DOWN))
			{
				moveMarioDown();
			}

			if (GetAsyncKeyState(VK_SPACE))
			{
				generateBulletRight();
			}

			if (GetAsyncKeyState(VK_CONTROL))
			{
				generateBulletLeft();
			}

			if (GetAsyncKeyState(VK_TAB))
			{
				isGameRunning = false;
			}
			printHealth();
			if (timer == 3)
			{
				if (enemy1Health > 0)
				{
					moveEnemy1();
				}
				else if (enemy1Health == 0 && flag1 == true)
				{
					eraseEnemy1();
					winningCount++;
					flag1 == false;
				}

				if (enemy2Health > 0)
				{
					moveEnemy2();
				}
				else if (enemy2Health == 0 && flag2 == true)
				{
					eraseEnemy2();
					winningCount++;
					flag2 == false;

				}

				if (enemy3Health > 0)
				{
					moveEnemy3();
				}
				else if (enemy3Health == 0 && flag3 == true)
				{
					eraseEnemy3();
					winningCount++;
					flag3 == false;

				}

				if (enemy4Health > 0)
				{
					moveEnemy4();
				}
				else if (enemy4Health == 0 && flag4 == true)
				{
					eraseEnemy4();
					winningCount++;
					flag4 == false;

				}

				timer = 0;
			}

			if (winningCount == 4)
			{
				break;
			}
			generateLift1();
			generateLift2();
			generateLift3();
			generateLift4();
			generateLift5();
			generateLift6();
			generateLift7();

			printStatus();
			printGameName();

			moveBulletRight();
			bulletCollisionWithEnemyRight();
			moveBulletLeft();
			bulletCollisionWithEnemyLeft();

			moveBulletRightEnemy1();
			moveBulletLeftEnemy1();

			moveBulletRightEnemy2();
			moveBulletLeftEnemy2();

			moveBulletRightEnemy3();
			moveBulletLeftEnemy3();

			moveBulletRightEnemy4();
			moveBulletLeftEnemy4();

			healthDecrement();
			timer++;
			Sleep(100);
		}
	}

	// menu 2 of the game to show the instructions

	public static void menu2()
	{
		topHeader();
		Console.Write("\n\n\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");
		Console.Write("1. Move the Arrow Up Key to move UP");
		Console.Write("\n");
		Console.Write("2. Move the Arrow Down Key to move DOWN");
		Console.Write("\n");
		Console.Write("3. Move the Arrow Right Key to move RIGHT");
		Console.Write("\n");
		Console.Write("4. Move the Arrow Down Key to move LEFT");
		Console.Write("\n");
		Console.Write("5. Press Space Key to fire Bullet from right side");
		Console.Write("\n");
		Console.Write("6. Press Control Key to fire Bullet from left side");
		Console.Write("\n");
		Console.Write("7. Character can only move UP and DOWN with Stairs");
		Console.Write("\n");
		Console.Write("8. Character can have only 3 Healths");
		Console.Write("\n");
		Console.Write("9. The Score can be seen at the bottom(middle) of the screen");
		Console.Write("\n");
		getCharacter();
	}

	// Menu 3 of the game for Character Information

	public static void menu3()
	{
		topHeader();
		Console.Write("\n\n\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");
		Console.Write("Main Character :\n\n");
		for (int i = 0; i < 5; i++)
		{
			Console.Write(character1[i]);
		}
		Console.Write("\n");

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character2[i]);
		}
		Console.Write("\n");

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character3[i]);
		}

		Console.Write("\n\n\n");

		Console.Write("Enemy # 1 :\n\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy1[index]);
		}
		Console.Write("\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy2[index]);
		}

		Console.Write("\n\n\n");

		Console.Write("Enemy # 2 :\n\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy1[index]);
		}
		Console.Write("\n");

		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy2[index]);
		}

		Console.Write("\n\n\n");

		Console.Write("Enemy # 3 :\n\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e3nemy1[index]);
		}
		Console.Write("\n");

		for (int index = 0; index < 6; index++)
		{
			Console.Write(e3nemy2[index]);
		}

		Console.Write("\n\n\n");

		Console.Write("Enemy # 4 :\n\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e4nemy1[index]);
		}
		Console.Write("\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e4nemy2[index]);
		}
		Console.Write("\n");

		getCharacter();
	}

	public static void getCharacter()
	{
		Console.Write("\n\n\n");
		Console.Write("Press any key to continue.......");
		Console.ReadKey();
	}

	public static void winningInterface()
	{
		Console.Write("\n\n\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
	}

	public static void removeHealth()
	{
		healthCounter--;
	}

	//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void healthDecrement();

	//----------------SCORE Print

	public static void printScore()
	{
		SetConsoleTextAttribute(hConsole, 10);
		gotoxy(40, 38);
		Console.Write("Score : ");
		Console.Write(score);
	}

	//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void healthDecrement();

	public static void addScore()
	{
		score++;
	}

	//-----------------------------------------------
	// Enemy1 Generate Bullet Left

	// functions for generating bullet of enemies
	public static void generateBulletEnemy1Left()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy1BulletLeftX[bulletCountLeftEnemy1] = e1nemyX - 1;
		enemy1BulletLeftY[bulletCountLeftEnemy1] = e1nemyY;
		char next = getcharatxy((short)(e1nemyX - 1), (short)e1nemyY);
		if (next == ' ')
		{
			gotoxy(e1nemyX - 1, e1nemyY);
			Console.Write(enemyBulletName);
			bulletCountLeftEnemy1++;
		}
	}

	// Enemy1 Generate Bullet Right

	public static void generateBulletEnemy1Right()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy1BulletRightX[bulletCountRightEnemy1] = e1nemyX + 6;
		enemy1BulletRightY[bulletCountRightEnemy1] = e1nemyY;
		char next = getcharatxy((short)(e1nemyX + 6), (short)e1nemyY);
		if (next == ' ')
		{
			gotoxy(e1nemyX + 6, e1nemyY);
			Console.Write(enemyBulletName);
			bulletCountRightEnemy1++;
		}
	}

	// Enemy2 Generate Bullet Left

	public static void generateBulletEnemy2Left()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy2BulletLeftX[bulletCountLeftEnemy2] = e2nemyX - 1;
		enemy2BulletLeftY[bulletCountLeftEnemy2] = e2nemyY;
		char next = getcharatxy((short)(e2nemyX - 1), (short)e2nemyY);
		if (next == ' ')
		{
			gotoxy(e2nemyX - 1, e2nemyY);
			Console.Write(enemyBulletName);
			bulletCountLeftEnemy2++;
		}
	}

	// Enemy2 Generate Bullet Right

	public static void generateBulletEnemy2Right()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy2BulletRightX[bulletCountRightEnemy2] = e2nemyX + 6;
		enemy2BulletRightY[bulletCountRightEnemy2] = e2nemyY;
		char next = getcharatxy((short)(e2nemyX + 6), (short)e2nemyY);
		if (next == ' ')
		{
			gotoxy(e2nemyX + 6, e2nemyY);
			Console.Write(enemyBulletName);
			bulletCountRightEnemy2++;
		}
	}

	// Enemy3 Generate Bullet Left

	public static void generateBulletEnemy3Left()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy3BulletLeftX[bulletCountLeftEnemy3] = e3nemyX - 1;
		enemy3BulletLeftY[bulletCountLeftEnemy3] = e3nemyY;
		char next = getcharatxy((short)(e3nemyX - 1), (short)e3nemyY);
		if (next == ' ')
		{
			gotoxy(e3nemyX - 1, e3nemyY);
			Console.Write(enemyBulletName);
			bulletCountLeftEnemy3++;
		}
	}

	// Enemy3 Generate Bullet Right

	public static void generateBulletEnemy3Right()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy3BulletRightX[bulletCountRightEnemy3] = e3nemyX + 6;
		enemy3BulletRightY[bulletCountRightEnemy3] = e3nemyY;
		char next = getcharatxy((short)(e3nemyX + 6), (short)e3nemyY);
		if (next == ' ')
		{
			gotoxy(e3nemyX + 6, e3nemyY);
			Console.Write(enemyBulletName);
			bulletCountRightEnemy3++;
		}
	}

	// Enemy4 Generate Bullet Left

	public static void generateBulletEnemy4Left()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy4BulletLeftX[bulletCountLeftEnemy4] = e4nemyX - 1;
		enemy4BulletLeftY[bulletCountLeftEnemy4] = e4nemyY;
		char next = getcharatxy((short)(e4nemyX - 1), (short)e4nemyY);
		if (next == ' ')
		{
			gotoxy(e4nemyX - 1, e4nemyY);
			Console.Write(enemyBulletName);
			bulletCountLeftEnemy4++;
		}
	}

	// Enemy3 Generate Bullet Right

	public static void generateBulletEnemy4Right()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy4BulletRightX[bulletCountRightEnemy4] = e4nemyX + 6;
		enemy4BulletRightY[bulletCountRightEnemy4] = e4nemyY;
		char next = getcharatxy((short)(e4nemyX + 6), (short)e4nemyY);
		if (next == ' ')
		{
			gotoxy(e4nemyX + 6, e4nemyY);
			Console.Write(enemyBulletName);
			bulletCountRightEnemy4++;
		}
	}

	// move the bullet of enemy1 to right

	// BULLET Movement of Enemies to RIGHT
	// Enemy 1
	public static void moveBulletRightEnemy1()
	{
		for (int x = 0; x < bulletCountRightEnemy1; x++)
		{
			char next = getcharatxy((short)(enemy1BulletRightX[x] + 1), (short)enemy1BulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRightEnemy1(enemy1BulletRightX[x], enemy1BulletRightY[x]);
				removeBulletfromArrayRightEnemy1(x);
			}
			else
			{
				eraseBulletRightEnemy1(enemy1BulletRightX[x], enemy1BulletRightY[x]);
				enemy1BulletRightX[x] = enemy1BulletRightX[x] + 1;
				printBulletRightEnemy1(enemy1BulletRightX[x], enemy1BulletRightY[x]);
			}
		}
	}

	public static void printBulletRightEnemy1(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletRightEnemy1(int x, int y)
	{

		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayRightEnemy1(int index)
	{
		for (int x = index; x < bulletCountRightEnemy1 - 1; x++)
		{
			enemy1BulletRightX[x] = enemy1BulletRightX[x + 1];
			enemy1BulletRightY[x] = enemy1BulletRightY[x + 1];
		}
		bulletCountRightEnemy1--;
	}

	// move the bullet of enemy2 to Right

	// Enemy2
	public static void moveBulletRightEnemy2()
	{
		for (int x = 0; x < bulletCountRightEnemy2; x++)
		{
			char next = getcharatxy((short)(enemy2BulletRightX[x] + 1), (short)enemy2BulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRightEnemy2(enemy2BulletRightX[x], enemy2BulletRightY[x]);
				removeBulletfromArrayRightEnemy2(x);
			}
			else
			{
				eraseBulletRightEnemy2(enemy2BulletRightX[x], enemy2BulletRightY[x]);
				enemy2BulletRightX[x] = enemy2BulletRightX[x] + 1;
				printBulletRightEnemy2(enemy2BulletRightX[x], enemy2BulletRightY[x]);
			}
		}
	}

	public static void printBulletRightEnemy2(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletRightEnemy2(int x, int y)
	{

		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayRightEnemy2(int index)
	{
		for (int x = index; x < bulletCountRightEnemy2 - 1; x++)
		{
			enemy2BulletRightX[x] = enemy2BulletRightX[x + 1];
			enemy2BulletRightY[x] = enemy2BulletRightY[x + 1];
		}
		bulletCountRightEnemy2--;
	}

	// move the bullet of enemy3 to Right

	// Enemy3
	public static void moveBulletRightEnemy3()
	{
		for (int x = 0; x < bulletCountRightEnemy3; x++)
		{
			char next = getcharatxy((short)(enemy3BulletRightX[x] + 1), (short)enemy3BulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRightEnemy3(enemy3BulletRightX[x], enemy3BulletRightY[x]);
				removeBulletfromArrayRightEnemy3(x);
			}
			else
			{
				eraseBulletRightEnemy3(enemy3BulletRightX[x], enemy3BulletRightY[x]);
				enemy3BulletRightX[x] = enemy3BulletRightX[x] + 1;
				printBulletRightEnemy3(enemy3BulletRightX[x], enemy3BulletRightY[x]);
			}
		}
	}

	public static void printBulletRightEnemy3(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletRightEnemy3(int x, int y)
	{

		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayRightEnemy3(int index)
	{
		for (int x = index; x < bulletCountRightEnemy3 - 1; x++)
		{
			enemy3BulletRightX[x] = enemy3BulletRightX[x + 1];
			enemy3BulletRightY[x] = enemy3BulletRightY[x + 1];
		}
		bulletCountRightEnemy3--;
	}

	// move the bullet of enemy4 to Right

	// Enemy4
	public static void moveBulletRightEnemy4()
	{
		for (int x = 0; x < bulletCountRightEnemy4; x++)
		{
			char next = getcharatxy((short)(enemy4BulletRightX[x] + 1), (short)enemy4BulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRightEnemy4(enemy4BulletRightX[x], enemy4BulletRightY[x]);
				removeBulletfromArrayRightEnemy4(x);
			}
			else
			{
				eraseBulletRightEnemy4(enemy4BulletRightX[x], enemy4BulletRightY[x]);
				enemy4BulletRightX[x] = enemy4BulletRightX[x] + 1;
				printBulletRightEnemy4(enemy4BulletRightX[x], enemy4BulletRightY[x]);
			}
		}
	}

	public static void printBulletRightEnemy4(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletRightEnemy4(int x, int y)
	{

		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayRightEnemy4(int index)
	{
		for (int x = index; x < bulletCountRightEnemy4 - 1; x++)
		{
			enemy4BulletRightX[x] = enemy4BulletRightX[x + 1];
			enemy4BulletRightY[x] = enemy4BulletRightY[x + 1];
		}
		bulletCountRightEnemy4--;
	}

	// move the bullet of enemy 1 to left

	// BULLET Movement of Enemies to LEFT
	// Enemy 1
	public static void moveBulletLeftEnemy1()
	{
		for (int x = 0; x < bulletCountLeftEnemy1; x++)
		{
			char next = getcharatxy((short)(enemy1BulletLeftX[x] - 1), (short)enemy1BulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeftEnemy1(enemy1BulletLeftX[x], enemy1BulletLeftY[x]);
				removeBulletfromArrayLeftEnemy1(x);
			}
			else
			{
				eraseBulletLeftEnemy1(enemy1BulletLeftX[x], enemy1BulletLeftY[x]);
				enemy1BulletLeftX[x] = enemy1BulletLeftX[x] - 1;
				printBulletLeftEnemy1(enemy1BulletLeftX[x], enemy1BulletLeftY[x]);
			}
		}
	}

	public static void printBulletLeftEnemy1(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);
		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletLeftEnemy1(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayLeftEnemy1(int index)
	{
		for (int x = index; x < bulletCountLeftEnemy1 - 1; x++)
		{
			enemy1BulletLeftX[x] = enemy1BulletLeftX[x + 1];
			enemy1BulletLeftY[x] = enemy1BulletLeftY[x + 1];
		}
		bulletCountLeftEnemy1--;
	}

	// move the bullet of enemy 2 to left

	// Enemy2
	public static void moveBulletLeftEnemy2()
	{
		for (int x = 0; x < bulletCountLeftEnemy2; x++)
		{
			char next = getcharatxy((short)(enemy2BulletLeftX[x] - 1), (short)enemy2BulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeftEnemy2(enemy2BulletLeftX[x], enemy2BulletLeftY[x]);
				removeBulletfromArrayLeftEnemy2(x);
			}
			else
			{
				eraseBulletLeftEnemy2(enemy2BulletLeftX[x], enemy2BulletLeftY[x]);
				enemy2BulletLeftX[x] = enemy2BulletLeftX[x] - 1;
				printBulletLeftEnemy2(enemy2BulletLeftX[x], enemy2BulletLeftY[x]);
			}
		}
	}

	public static void printBulletLeftEnemy2(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletLeftEnemy2(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayLeftEnemy2(int index)
	{
		for (int x = index; x < bulletCountLeftEnemy2 - 1; x++)
		{
			enemy2BulletLeftX[x] = enemy2BulletLeftX[x + 1];
			enemy2BulletLeftY[x] = enemy2BulletLeftY[x + 1];
		}
		bulletCountLeftEnemy2--;
	}

	// move the bullet of enemy 3 to left

	// Enemy 3
	public static void moveBulletLeftEnemy3()
	{
		for (int x = 0; x < bulletCountLeftEnemy3; x++)
		{
			char next = getcharatxy((short)(enemy3BulletLeftX[x] - 1), (short)enemy3BulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeftEnemy3(enemy3BulletLeftX[x], enemy3BulletLeftY[x]);
				removeBulletfromArrayLeftEnemy3(x);
			}
			else
			{
				eraseBulletLeftEnemy3(enemy3BulletLeftX[x], enemy3BulletLeftY[x]);
				enemy3BulletLeftX[x] = enemy3BulletLeftX[x] - 1;
				printBulletLeftEnemy3(enemy3BulletLeftX[x], enemy3BulletLeftY[x]);
			}
		}
	}

	public static void printBulletLeftEnemy3(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);
		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletLeftEnemy3(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayLeftEnemy3(int index)
	{
		for (int x = index; x < bulletCountLeftEnemy3 - 1; x++)
		{
			enemy3BulletLeftX[x] = enemy3BulletLeftX[x + 1];
			enemy3BulletLeftY[x] = enemy3BulletLeftY[x + 1];
		}
		bulletCountLeftEnemy3--;
	}

	// move the bullet of enemy 4 to left

	// Enemy 4
	public static void moveBulletLeftEnemy4()
	{
		for (int x = 0; x < bulletCountLeftEnemy4; x++)
		{
			char next = getcharatxy((short)(enemy4BulletLeftX[x] - 1), (short)enemy4BulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeftEnemy4(enemy4BulletLeftX[x], enemy4BulletLeftY[x]);
				removeBulletfromArrayLeftEnemy4(x);
			}
			else
			{
				eraseBulletLeftEnemy4(enemy4BulletLeftX[x], enemy4BulletLeftY[x]);
				enemy4BulletLeftX[x] = enemy4BulletLeftX[x] - 1;
				printBulletLeftEnemy4(enemy4BulletLeftX[x], enemy4BulletLeftY[x]);
			}
		}
	}

	public static void printBulletLeftEnemy4(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);
		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletLeftEnemy4(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayLeftEnemy4(int index)
	{
		for (int x = index; x < bulletCountLeftEnemy4 - 1; x++)
		{
			enemy4BulletLeftX[x] = enemy4BulletLeftX[x + 1];
			enemy4BulletLeftY[x] = enemy4BulletLeftY[x + 1];
		}
		bulletCountLeftEnemy4--;
	}

	// print the status of the game

	public static void printStatus()
	{
		SetConsoleTextAttribute(hConsole, 10);
		gotoxy(109, 38);
		Console.Write(status);
	}

	// print the health of the main Character

	public static void printHealth()
	{
		SetConsoleTextAttribute(hConsole, 10);
		gotoxy(75, 38);
		Console.Write(healthCounter);
	}

	// print the Name of the Game

	public static void printGameName()
	{
		SetConsoleTextAttribute(hConsole, 2);
		gotoxy(18, 38);
		Console.Write(gameName);
	}

	//            character variables
	public static int pX = 6;
	public static int pY = 32;

	public static int[] bulletRightX = new int[100];
	public static int[] bulletRightY = new int[100];
	public static int bulletCountRight = 0;

	public static int[] bulletLeftX = new int[100];
	public static int[] bulletLeftY = new int[100];
	public static int bulletCountLeft = 0;

	// BULLET variables for Enemies RIGHT
	// Enemy 1
	public static int[] enemy1BulletRightX = new int[100];
	public static int[] enemy1BulletRightY = new int[100];
	public static int bulletCountRightEnemy1 = 0;
	// Enemy 2
	public static int[] enemy2BulletRightX = new int[100];
	public static int[] enemy2BulletRightY = new int[100];
	public static int bulletCountRightEnemy2 = 0;
	// Enemy 3
	public static int[] enemy3BulletRightX = new int[100];
	public static int[] enemy3BulletRightY = new int[100];
	public static int bulletCountRightEnemy3 = 0;
	// Enemy 4
	public static int[] enemy4BulletRightX = new int[100];
	public static int[] enemy4BulletRightY = new int[100];
	public static int bulletCountRightEnemy4 = 0;

	// BULLET variables for Enemies LEFT
	// Enemy 1
	public static int[] enemy1BulletLeftX = new int[100];
	public static int[] enemy1BulletLeftY = new int[100];
	public static int bulletCountLeftEnemy1 = 0;
	// Enemy 2
	public static int[] enemy2BulletLeftX = new int[100];
	public static int[] enemy2BulletLeftY = new int[100];
	public static int bulletCountLeftEnemy2 = 0;
	// Enemy 3
	public static int[] enemy3BulletLeftX = new int[100];
	public static int[] enemy3BulletLeftY = new int[100];
	public static int bulletCountLeftEnemy3 = 0;
	// Enemy 4
	public static int[] enemy4BulletLeftX = new int[100];
	public static int[] enemy4BulletLeftY = new int[100];
	public static int bulletCountLeftEnemy4 = 0;

	public static int e1nemyX = 60;
	public static int e1nemyY = 5;

	public static int e2nemyX = 12;
	public static int e2nemyY = 19;

	public static int e3nemyX = 45;
	public static int e3nemyY = 26;

	public static int e4nemyX = 109;
	public static int e4nemyY = 19;

	// for the draw of maze
	public static char box1 = 219;
	public static char box2 = 177;
	public static char box3 = 178;

	public static char left_character = 174;
	public static char right_character = 175;
	public static char box = 219;
	public static char emoji = 2;
	public static char a = 219;
	public static char lift = 22;
	public static char health = 3;
	public static int healthCounter = 100;

	public static char enemyBulletName = 15;
	public static int bulletColour = 13;

	public static int timer = 0;

	public static string enemyDirection1 = "Left";
	public static string enemyDirection2 = "Left";
	public static string enemyDirection3 = "Left";
	public static string enemyDirection4 = "Left";

	public static int score = 0;

	public static string status = "Playing";
	public static string gameName = "FAST MANIA";

	//           main character
	public static char[] character1 = { ' ', ' ', emoji, ' ', ' ' };
	public static char[] character2 = { left_character, box, box, box, right_character };
	public static char[] character3 = { '_', box, ' ', box, '_' };
	//           enemy 1
	public static char[] e1nemy1 = { '<', '_', box, box, '_', '>' };
	public static char[] e1nemy2 = { ' ', '0', ' ', ' ', '0', ' ' };

	//           enemy 2
	public static char[] e2nemy1 = { '<', '_', box, box, '_', '>' };
	public static char[] e2nemy2 = { ' ', '0', ' ', ' ', '0', ' ' };

	//           enemy 3
	public static char[] e3nemy1 = { '<', '_', box, box, '_', '>' };
	public static char[] e3nemy2 = { ' ', '0', ' ', ' ', '0', ' ' };

	//           enemy 4
	public static char[] e4nemy1 = { '<', '_', box, box, '_', '>' };
	public static char[] e4nemy2 = { ' ', '0', ' ', ' ', '0', ' ' };

	public static bool flag1 = true;
	public static bool flag2 = true;
	public static bool flag3 = true;
	public static bool flag4 = true;

	public static int enemy1Health = 50;
	public static int enemy2Health = 50;
	public static int enemy3Health = 50;
	public static int enemy4Health = 50;
	public static int winningCount = 0;

	//             main function

	static int Main()
	{
		LoadCoordinate();

		while (loginOption != "4")
		{
			if (winningCount == 4)
			{
				system("cls");
				topHeader();
				winningInterface();
				getCharacter();
				break;
			}
			system("cls");
			gameEntrance();
			Console.ReadKey();
			system("cls");
			topHeader();
			loginOption = loginMenu();
			system("cls");
			if (loginOption == "1")
			{
				menu1();
			}

			else if (loginOption == "2")
			{
				menu2();
			}

			else if (loginOption == "3")
			{
				menu3();
			}

			else if (loginOption != "1" || loginOption != "2" || loginOption != "3" || loginOption != "4")
			{
				topHeader();
				Console.Write("\n\n\n\n");
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write("\n");
				Console.Write("\n\n");
				Console.Write("Thanks for Playing Fast Mania\n");
			}
			storeCharacterCoordinate();
		}
	}

	public static void storeHealth()
	{
	}

	public static void storeCoordinates()
	{
		fstream file = new fstream();
		file.open("CharacterInfo.txt", ios.@out);
		file << pX << "\n";
		file << pY << "\n";
		file << e1nemyX << "\n";
		file << e1nemyY << "\n";
		file << e2nemyX << "\n";
		file << e2nemyX << "\n";
		file << e3nemyX << "\n";
		file << e3nemyX << "\n";
		file << e4nemyX << "\n";
		file << e4nemyX << "\n";

		file.close();
	}

	public static void storeScore()
	{
		fstream file = new fstream();
		file.open("StoreScore.txt", ios.@out);
		file << score;

		file.close();
	}

	public static void storeHealth()
	{
		fstream file = new fstream();
		file.open("Health.txt", ios.@out);
		file << healthCounter;

		file.close();
	}

	public static IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	public static void healthDecrement()
	{
		char next = getcharatxy((short)(pX - 1), (short)pY);
		char next1 = getcharatxy((short)(pX + 5), (short)pY);
		char next2 = getcharatxy((short)(pX - 1), (short)(pY + 1));
		char next3 = getcharatxy((short)(pX + 5), (short)(pY + 1));
		if (next == (char)15 || next1 == (char)15 || next2 == (char)15 || next3 == (char)15)
		{
			healthCounter--;
		}
	}

	//            functions prototypes
	public static void printMaze()
	{
		// 87
		SetConsoleTextAttribute(hConsole, 3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("                                                                                                                        ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                   ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                                   ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                     ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("     ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("           ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("     ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                           ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("     ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                           ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write("                                                                                                              ");
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("    ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("    ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("                                                                                                                        ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("             ");
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write(box1);
		Console.Write("                                                                                        ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("              ");
		Console.Write(box1);
		Console.Write("               ");
		Console.Write(box1);
		Console.Write("                                  Health :                          STATUS :             ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("              ");
		Console.Write(box1);
		Console.Write("               ");
		Console.Write(box1);
		Console.Write("                                                                                         ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("             ");
		Console.Write(box2);
		Console.Write(box1);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box1);
		Console.Write(box2);
		Console.Write("                                                                                        ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write("              ");
		Console.Write(box1);
		Console.Write("               ");
		Console.Write(box1);
		Console.Write("                                                                                         ");
		Console.Write(box3);
		Console.Write("\n");
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write(box3);
		Console.Write("\n");
	}

	public static void gotoxy(int x, int y)
	{
		COORD coordinate = new COORD();
		coordinate.X = x;
		coordinate.Y = y;
		SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinate);
	}

	public static char getcharatxy(short x, short y)
	{
		CHAR_INFO ci = new CHAR_INFO();
		COORD xy = new COORD(0, 0);
		SMALL_RECT rect = new SMALL_RECT(x, y, x, y);
		COORD coordbufsize = new COORD();
		coordbufsize.X = 1;
		coordbufsize.Y = 1;
		return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), ci, coordbufsize, xy, rect) ? ci.Char.AsciiChar : ' ';
	}

	//  -------------------print the main character

	public static void printCharacter()
	{
		SetConsoleTextAttribute(hConsole, 1);

		gotoxy(pX, pY);

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character1[i]);
		}
		gotoxy(pX, pY + 1);

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character2[i]);
		}
		gotoxy(pX, pY + 2);

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character3[i]);
		}
	}

	//---------------------Erase the main character

	public static void eraseCharacter()
	{
		gotoxy(pX, pY);
		for (int i = 0; i < 5; i++)
		{
			Console.Write(" ");
		}
		gotoxy(pX, pY + 1);
		for (int i = 0; i < 5; i++)
		{
			Console.Write(" ");
		}
		gotoxy(pX, pY + 2);
		for (int i = 0; i < 5; i++)
		{
			Console.Write(" ");
		}
	}

	// Generates the lift # 1

	public static void generateLift1()
	{
		SetConsoleTextAttribute(hConsole, 6);

		int x = 36;
		int y = 7;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 2

	public static void generateLift2()
	{
		SetConsoleTextAttribute(hConsole, 6);

		int x = 81;
		int y = 7;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 3

	public static void generateLift3()
	{
		SetConsoleTextAttribute(hConsole, 6);

		int x = 51;
		int y = 14;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 4

	public static void generateLift4()
	{
		SetConsoleTextAttribute(hConsole, 6);

		int x = 67;
		int y = 14;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 5

	public static void generateLift5()
	{
		SetConsoleTextAttribute(hConsole, 6);

		int x = 33;
		int y = 21;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 6

	public static void generateLift6()
	{
		SetConsoleTextAttribute(hConsole, 6);

		int x = 84;
		int y = 21;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	// Generates the lift # 7

	public static void generateLift7()
	{
		SetConsoleTextAttribute(hConsole, 6);

		int x = 59;
		int y = 28;
		for (int i = 0; i < 7; i++)
		{
			gotoxy(x, y);
			Console.Write("|");
			for (int i = x + 1; i <= x + 3; i++)
			{
				gotoxy(i, y);
				Console.Write(lift);
			}
			gotoxy(x + 4, y);
			Console.Write("|");
			y++;
		}
	}

	//------------------------Move Mario Left

	public static void moveMarioLeft()
	{
		char next1 = getcharatxy((short)(pX - 1), (short)pY);
		char next2 = getcharatxy((short)(pX - 1), (short)(pY + 1));
		char next3 = getcharatxy((short)(pX - 1), (short)(pY + 2));
		char next4 = getcharatxy((short)(pX - 1), (short)(pY + 3));

		if (((next1 == ' ' && next2 == ' ' && next3 == ' ') || (next1 == '|' && next2 == '|' && next3 == '|') || (next1 == lift && next2 == lift && next3 == lift && next3 == lift)) && (next4 != ' '))
		{
			eraseCharacter();
			pX = pX - 1;
			printCharacter();
		}
		if (next1 == enemyBulletName || next2 == enemyBulletName || next3 == enemyBulletName || next4 == enemyBulletName)
		{
			healthCounter--;
		}
	}

	//------------------------Move Mario Right

	public static void moveMarioRight()
	{
		char next1 = getcharatxy((short)(pX + 5), (short)pY);
		char next2 = getcharatxy((short)(pX + 5), (short)(pY + 1));
		char next3 = getcharatxy((short)(pX + 5), (short)(pY + 2));
		char next4 = getcharatxy((short)(pX + 5), (short)(pY + 3));
		if (((next1 == ' ' && next2 == ' ' && next3 == ' ') || (next1 == '|' && next2 == '|' && next3 == '|') || (next1 == lift && next2 == lift && next3 == lift && next3 == lift)) && (next4 != ' '))
		{
			eraseCharacter();
			pX = pX + 1;
			printCharacter();
		}
		if (next1 == enemyBulletName || next2 == enemyBulletName || next3 == enemyBulletName || next4 == enemyBulletName)
		{
			healthCounter--;
		}
	}

	//------------------------Move Mario Up

	public static void moveMarioUp()
	{
		char next1 = getcharatxy((short)pX, (short)(pY - 1));
		char next2 = getcharatxy((short)(pX + 1), (short)(pY - 1));
		char next3 = getcharatxy((short)(pX + 2), (short)(pY - 1));
		char next4 = getcharatxy((short)(pX + 3), (short)(pY - 1));
		char next5 = getcharatxy((short)(pX + 4), (short)(pY - 1));
		char next6 = getcharatxy((short)(pX + 5), (short)pY);
		char next7 = getcharatxy((short)(pX - 1), (short)pY);
		char next8 = getcharatxy((short)(pX + 5), (short)(pY + 1));
		char next9 = getcharatxy((short)(pX - 1), (short)(pY + 1));
		char next10 = getcharatxy((short)(pX + 5), (short)(pY + 2));
		char next11 = getcharatxy((short)(pX - 1), (short)(pY + 2));
		if ((next1 == '|' && next2 == lift && next3 == lift && next4 == lift && next5 == '|') || (next6 == box1 || next7 == box1) || (next8 == box1 || next9 == box1) || (next10 == box1 || next11 == box1))

		{
			eraseCharacter();
			pY = pY - 1;
			printCharacter();
		}
	}

	//------------------------Move Mario Down

	public static void moveMarioDown()
	{
		char next1 = getcharatxy((short)pX, (short)(pY + 3));
		char next2 = getcharatxy((short)(pX + 1), (short)(pY + 3));
		char next3 = getcharatxy((short)(pX + 2), (short)(pY + 3));
		char next4 = getcharatxy((short)(pX + 3), (short)(pY + 3));
		char next5 = getcharatxy((short)(pX + 4), (short)(pY + 3));

		if ((next1 == '|' && next2 == lift && next3 == lift && next4 == lift && next5 == '|'))
		{
			eraseCharacter();
			pY = pY + 1;
			printCharacter();
		}
	}
	//-----------moveEnemy1


	public static void moveEnemy1()
	{
		if (enemyDirection1 == "Right")
		{
			char next = getcharatxy((short)(e1nemyX + 6), (short)e1nemyY);
			char next1 = getcharatxy((short)(e1nemyX + 6), (short)(e1nemyY + 2));
			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy1();
				e1nemyX++;
				printEnemy1(e1nemyX);
			}
			if (next1 == ' ')

			{
				enemyDirection1 = "Left";
			}
			generateBulletEnemy1Right();
		}

		if (enemyDirection1 == "Left")
		{
			char next = getcharatxy((short)(e1nemyX - 1), (short)e1nemyY);
			char next1 = getcharatxy((short)(e1nemyX - 1), (short)(e1nemyY + 2));
			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy1();
				e1nemyX--;
				printEnemy1(e1nemyX);
			}
			if (next1 == ' ')
			{
				enemyDirection1 = "Right";
			}
			generateBulletEnemy1Left();
		}
	}

	//-----------moveEnemy2


	public static void moveEnemy2()
	{
		if (enemyDirection2 == "Right")
		{
			char next = getcharatxy((short)(e2nemyX + 6), (short)e2nemyY);
			char next1 = getcharatxy((short)(e2nemyX + 6), (short)(e2nemyY + 2));
			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))

			{
				eraseEnemy2();
				e2nemyX++;
				printEnemy2(e2nemyX);
			}
			if (next != ' ')
			{
				enemyDirection2 = "Left";
			}
			generateBulletEnemy2Right();
		}

		if (enemyDirection2 == "Left")
		{
			char next = getcharatxy((short)(e2nemyX - 1), (short)e2nemyY);
			char next1 = getcharatxy((short)(e2nemyX - 1), (short)(e2nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy2();
				e2nemyX--;
				printEnemy2(e2nemyX);
			}
			if (next != ' ')
			{
				enemyDirection2 = "Right";
			}
			generateBulletEnemy2Left();
		}
	}

	//-----------moveEnemy3


	public static void moveEnemy3()
	{
		if (enemyDirection3 == "Right")
		{
			char next = getcharatxy((short)(e3nemyX + 6), (short)e3nemyY);
			char next1 = getcharatxy((short)(e3nemyX + 6), (short)(e3nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy3();
				e3nemyX++;
				printEnemy3(e3nemyX);
			}
			if (next != ' ')
			{
				enemyDirection3 = "Left";
			}
			generateBulletEnemy3Right();
		}

		if (enemyDirection3 == "Left")
		{
			char next = getcharatxy((short)(e3nemyX - 1), (short)e3nemyY);
			char next1 = getcharatxy((short)(e3nemyX - 1), (short)(e3nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))

			{
				eraseEnemy3();
				e3nemyX--;
				printEnemy3(e3nemyX);
			}
			if (next != ' ')
			{
				enemyDirection3 = "Right";
			}
			generateBulletEnemy3Left();
		}
	}

	//-----------moveEnemy4


	public static void moveEnemy4()
	{
		if (enemyDirection4 == "Right")
		{
			char next = getcharatxy((short)(e4nemyX + 6), (short)e4nemyY);
			char next1 = getcharatxy((short)(e4nemyX + 6), (short)(e4nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))
			{
				eraseEnemy4();
				e4nemyX++;
				printEnemy4(e4nemyX);
			}
			if (next != ' ')
			{
				enemyDirection4 = "Left";
			}
			generateBulletEnemy4Right();
		}

		if (enemyDirection4 == "Left")
		{
			char next = getcharatxy((short)(e4nemyX - 1), (short)e4nemyY);
			char next1 = getcharatxy((short)(e4nemyX - 1), (short)(e4nemyY + 2));

			if ((next == ' ') && ((next1 == box1) || (next1 == lift) || (next1 == '|')))

			{
				eraseEnemy4();
				e4nemyX--;
				printEnemy4(e4nemyX);
			}
			if (next != ' ')
			{
				enemyDirection4 = "Right";
			}
			generateBulletEnemy4Left();
		}
	}

	//--------------------Print Enemy 1


	public static void printEnemy1(int e1nemyX)
	{
		SetConsoleTextAttribute(hConsole, 4);
		gotoxy(e1nemyX, e1nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy1[index]);
		}
		gotoxy(e1nemyX, e1nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy2[index]);
		}
	}

	//--------------------Print Enemy 2


	public static void printEnemy2(int e2nemyX)
	{
		SetConsoleTextAttribute(hConsole, 4);

		gotoxy(e2nemyX, e2nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy1[index]);
		}
		gotoxy(e2nemyX, e2nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy2[index]);
		}
	}

	//--------------------Print Enemy 3


	public static void printEnemy3(int e3nemyX)
	{
		SetConsoleTextAttribute(hConsole, 4);

		gotoxy(e3nemyX, e3nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e3nemy1[index]);
		}
		gotoxy(e3nemyX, e3nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e3nemy2[index]);
		}
	}

	//--------------------Print Enemy 4


	public static void printEnemy4(int e4nemyX)
	{
		SetConsoleTextAttribute(hConsole, 4);

		gotoxy(e4nemyX, e4nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e4nemy1[index]);
		}
		gotoxy(e4nemyX, e4nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e4nemy2[index]);
		}
	}

	//-----------erase enemy1

	public static void eraseEnemy1()
	{
		gotoxy(e1nemyX, e1nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e1nemyX, e1nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	//-----------erase enemy2

	public static void eraseEnemy2()
	{
		gotoxy(e2nemyX, e2nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e2nemyX, e2nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	//-----------erase enemy3

	public static void eraseEnemy3()
	{
		gotoxy(e3nemyX, e3nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e3nemyX, e3nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	//-----------erase enemy 4

	public static void eraseEnemy4()
	{
		gotoxy(e4nemyX, e4nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e4nemyX, e4nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	//-----------------------Generates the bullet of the main character to RIGHTTTTT


	public static void generateBulletRight()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		char bulletRight = 16;
		bulletRightX[bulletCountRight] = pX + 5;
		bulletRightY[bulletCountRight] = pY + 1;
		char next = getcharatxy((short)(pX + 5), (short)(pY + 1));
		if (next == ' ')

		{
			gotoxy(pX + 5, pY + 1);
			Console.Write(bulletRight);
			bulletCountRight++;
		}
	}

	public static void moveBulletRight()
	{
		for (int x = 0; x < bulletCountRight; x++)
		{
			char next = getcharatxy((short)(bulletRightX[x] + 1), (short)bulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
			}
			else
			{
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				bulletRightX[x] = bulletRightX[x] + 1;
				printBulletRight(bulletRightX[x], bulletRightY[x]);
			}
		}
	}

	public static void eraseBulletRight(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void printBulletRight(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		char bulletRight = 16;
		gotoxy(x, y);
		Console.Write(bulletRight);
	}

	public static void removeBulletfromArrayRight(int index)
	{
		for (int x = index; x < bulletCountRight - 1; x++)
		{
			bulletRightX[x] = bulletRightX[x + 1];
			bulletRightY[x] = bulletRightY[x + 1];
		}
		bulletCountRight--;
	}

	//------------------Collision woth the enemy

	public static void bulletCollisionWithEnemyRight()

	{
		for (int x = 0; x < bulletCountRight; x++)
		{
			if (bulletRightX[x] + 1 == e1nemyX && (bulletRightY[x] == e1nemyY || bulletRightY[x] == e1nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
				enemy1Health--;
			}

			if (bulletRightX[x] + 1 == e2nemyX && (bulletRightY[x] == e2nemyY || bulletRightY[x] == e2nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
				enemy2Health--;
			}
			if (bulletRightX[x] + 1 == e3nemyX && (bulletRightY[x] == e3nemyY || bulletRightY[x] == e3nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
				enemy3Health--;
			}
			if (bulletRightX[x] + 1 == e4nemyX && (bulletRightY[x] == e4nemyY || bulletRightY[x] == e4nemyY + 1))
			{
				addScore();
				eraseBulletRight(bulletRightX[x], bulletRightY[x]);
				removeBulletfromArrayRight(x);
				enemy4Health--;
			}
		}
	}

	//---------move bullet Left------------------------------------------------------------------------------------------------------------

	public static void generateBulletLeft()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		char bulletLeft = 17;
		bulletLeftX[bulletCountLeft] = pX - 1;
		bulletLeftY[bulletCountLeft] = pY + 1;
		char next = getcharatxy((short)(pX - 1), (short)(pY + 1));
		if (next == ' ')
		{
			gotoxy(pX - 1, pY + 1);
			Console.Write(bulletLeft);
			bulletCountLeft++;
		}
	}

	public static void moveBulletLeft()
	{
		for (int x = 0; x < bulletCountLeft; x++)
		{
			char next = getcharatxy((short)(bulletLeftX[x] - 1), (short)bulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
			}
			else
			{
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				bulletLeftX[x] = bulletLeftX[x] - 1;
				printBulletLeft(bulletLeftX[x], bulletLeftY[x]);
			}
		}
	}

	public static void eraseBulletLeft(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void printBulletLeft(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		char bulletLeft = 17;
		gotoxy(x, y);
		Console.Write(bulletLeft);
	}

	public static void removeBulletfromArrayLeft(int index)
	{
		for (int x = index; x < bulletCountLeft - 1; x++)
		{
			bulletLeftX[x] = bulletLeftX[x + 1];
			bulletLeftY[x] = bulletLeftY[x + 1];
		}
		bulletCountLeft--;
	}

	//------------------Collision with the enemy Left---------------------------------

	public static void bulletCollisionWithEnemyLeft()

	{
		for (int x = 0; x < bulletCountLeft; x++)
		{
			if (bulletLeftX[x] - 1 == e1nemyX + 5 && (bulletLeftY[x] == e1nemyY || bulletLeftY[x] == e1nemyY + 1))
			{
				addScore();
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
				enemy1Health--;
			}

			if (bulletLeftX[x] - 1 == e2nemyX + 5 && (bulletLeftY[x] == e2nemyY || bulletLeftY[x] == e2nemyY + 1))
			{
				addScore();
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
				enemy2Health--;
			}
			if (bulletLeftX[x] - 1 == e3nemyX + 5 && (bulletLeftY[x] == e3nemyY || bulletLeftY[x] == e3nemyY + 1))
			{
				addScore();
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
				enemy3Health--;
			}
			if (bulletLeftX[x] - 1 == e4nemyX + 5 && (bulletLeftY[x] == e4nemyY || bulletLeftY[x] == e4nemyY + 1))
			{
				addScore();
				eraseBulletLeft(bulletLeftX[x], bulletLeftY[x]);
				removeBulletfromArrayLeft(x);
				enemy4Health--;
			}
		}
	}

	//----------------SCORE Print

	public static void printScore()
	{
		SetConsoleTextAttribute(hConsole, 10);
		gotoxy(40, 38);
		Console.Write("Score : ");
		Console.Write(score);
	}

	//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void healthDecrement();

	public static void addScore()
	{
		score++;
	}

	//-----------------------------------------------
	// Enemy1 Generate Bullet Left

	// functions for generating bullet of enemies
	public static void generateBulletEnemy1Left()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy1BulletLeftX[bulletCountLeftEnemy1] = e1nemyX - 1;
		enemy1BulletLeftY[bulletCountLeftEnemy1] = e1nemyY;
		char next = getcharatxy((short)(e1nemyX - 1), (short)e1nemyY);
		if (next == ' ')
		{
			gotoxy(e1nemyX - 1, e1nemyY);
			Console.Write(enemyBulletName);
			bulletCountLeftEnemy1++;
		}
	}

	// Enemy1 Generate Bullet Right

	public static void generateBulletEnemy1Right()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy1BulletRightX[bulletCountRightEnemy1] = e1nemyX + 6;
		enemy1BulletRightY[bulletCountRightEnemy1] = e1nemyY;
		char next = getcharatxy((short)(e1nemyX + 6), (short)e1nemyY);
		if (next == ' ')
		{
			gotoxy(e1nemyX + 6, e1nemyY);
			Console.Write(enemyBulletName);
			bulletCountRightEnemy1++;
		}
	}

	// Enemy2 Generate Bullet Left

	public static void generateBulletEnemy2Left()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy2BulletLeftX[bulletCountLeftEnemy2] = e2nemyX - 1;
		enemy2BulletLeftY[bulletCountLeftEnemy2] = e2nemyY;
		char next = getcharatxy((short)(e2nemyX - 1), (short)e2nemyY);
		if (next == ' ')
		{
			gotoxy(e2nemyX - 1, e2nemyY);
			Console.Write(enemyBulletName);
			bulletCountLeftEnemy2++;
		}
	}

	// Enemy2 Generate Bullet Right

	public static void generateBulletEnemy2Right()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy2BulletRightX[bulletCountRightEnemy2] = e2nemyX + 6;
		enemy2BulletRightY[bulletCountRightEnemy2] = e2nemyY;
		char next = getcharatxy((short)(e2nemyX + 6), (short)e2nemyY);
		if (next == ' ')
		{
			gotoxy(e2nemyX + 6, e2nemyY);
			Console.Write(enemyBulletName);
			bulletCountRightEnemy2++;
		}
	}

	// Enemy3 Generate Bullet Left

	public static void generateBulletEnemy3Left()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy3BulletLeftX[bulletCountLeftEnemy3] = e3nemyX - 1;
		enemy3BulletLeftY[bulletCountLeftEnemy3] = e3nemyY;
		char next = getcharatxy((short)(e3nemyX - 1), (short)e3nemyY);
		if (next == ' ')
		{
			gotoxy(e3nemyX - 1, e3nemyY);
			Console.Write(enemyBulletName);
			bulletCountLeftEnemy3++;
		}
	}

	// Enemy3 Generate Bullet Right

	public static void generateBulletEnemy3Right()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy3BulletRightX[bulletCountRightEnemy3] = e3nemyX + 6;
		enemy3BulletRightY[bulletCountRightEnemy3] = e3nemyY;
		char next = getcharatxy((short)(e3nemyX + 6), (short)e3nemyY);
		if (next == ' ')
		{
			gotoxy(e3nemyX + 6, e3nemyY);
			Console.Write(enemyBulletName);
			bulletCountRightEnemy3++;
		}
	}

	// Enemy4 Generate Bullet Left

	public static void generateBulletEnemy4Left()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy4BulletLeftX[bulletCountLeftEnemy4] = e4nemyX - 1;
		enemy4BulletLeftY[bulletCountLeftEnemy4] = e4nemyY;
		char next = getcharatxy((short)(e4nemyX - 1), (short)e4nemyY);
		if (next == ' ')
		{
			gotoxy(e4nemyX - 1, e4nemyY);
			Console.Write(enemyBulletName);
			bulletCountLeftEnemy4++;
		}
	}

	// Enemy3 Generate Bullet Right

	public static void generateBulletEnemy4Right()
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		enemy4BulletRightX[bulletCountRightEnemy4] = e4nemyX + 6;
		enemy4BulletRightY[bulletCountRightEnemy4] = e4nemyY;
		char next = getcharatxy((short)(e4nemyX + 6), (short)e4nemyY);
		if (next == ' ')
		{
			gotoxy(e4nemyX + 6, e4nemyY);
			Console.Write(enemyBulletName);
			bulletCountRightEnemy4++;
		}
	}

	// move the bullet of enemy1 to right

	// BULLET Movement of Enemies to RIGHT
	// Enemy 1
	public static void moveBulletRightEnemy1()
	{
		for (int x = 0; x < bulletCountRightEnemy1; x++)
		{
			char next = getcharatxy((short)(enemy1BulletRightX[x] + 1), (short)enemy1BulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRightEnemy1(enemy1BulletRightX[x], enemy1BulletRightY[x]);
				removeBulletfromArrayRightEnemy1(x);
			}
			else
			{
				eraseBulletRightEnemy1(enemy1BulletRightX[x], enemy1BulletRightY[x]);
				enemy1BulletRightX[x] = enemy1BulletRightX[x] + 1;
				printBulletRightEnemy1(enemy1BulletRightX[x], enemy1BulletRightY[x]);
			}
		}
	}

	public static void printBulletRightEnemy1(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletRightEnemy1(int x, int y)
	{

		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayRightEnemy1(int index)
	{
		for (int x = index; x < bulletCountRightEnemy1 - 1; x++)
		{
			enemy1BulletRightX[x] = enemy1BulletRightX[x + 1];
			enemy1BulletRightY[x] = enemy1BulletRightY[x + 1];
		}
		bulletCountRightEnemy1--;
	}

	// move the bullet of enemy2 to Right

	// Enemy2
	public static void moveBulletRightEnemy2()
	{
		for (int x = 0; x < bulletCountRightEnemy2; x++)
		{
			char next = getcharatxy((short)(enemy2BulletRightX[x] + 1), (short)enemy2BulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRightEnemy2(enemy2BulletRightX[x], enemy2BulletRightY[x]);
				removeBulletfromArrayRightEnemy2(x);
			}
			else
			{
				eraseBulletRightEnemy2(enemy2BulletRightX[x], enemy2BulletRightY[x]);
				enemy2BulletRightX[x] = enemy2BulletRightX[x] + 1;
				printBulletRightEnemy2(enemy2BulletRightX[x], enemy2BulletRightY[x]);
			}
		}
	}

	public static void printBulletRightEnemy2(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletRightEnemy2(int x, int y)
	{

		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayRightEnemy2(int index)
	{
		for (int x = index; x < bulletCountRightEnemy2 - 1; x++)
		{
			enemy2BulletRightX[x] = enemy2BulletRightX[x + 1];
			enemy2BulletRightY[x] = enemy2BulletRightY[x + 1];
		}
		bulletCountRightEnemy2--;
	}

	// move the bullet of enemy3 to Right

	// Enemy3
	public static void moveBulletRightEnemy3()
	{
		for (int x = 0; x < bulletCountRightEnemy3; x++)
		{
			char next = getcharatxy((short)(enemy3BulletRightX[x] + 1), (short)enemy3BulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRightEnemy3(enemy3BulletRightX[x], enemy3BulletRightY[x]);
				removeBulletfromArrayRightEnemy3(x);
			}
			else
			{
				eraseBulletRightEnemy3(enemy3BulletRightX[x], enemy3BulletRightY[x]);
				enemy3BulletRightX[x] = enemy3BulletRightX[x] + 1;
				printBulletRightEnemy3(enemy3BulletRightX[x], enemy3BulletRightY[x]);
			}
		}
	}

	public static void printBulletRightEnemy3(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletRightEnemy3(int x, int y)
	{

		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayRightEnemy3(int index)
	{
		for (int x = index; x < bulletCountRightEnemy3 - 1; x++)
		{
			enemy3BulletRightX[x] = enemy3BulletRightX[x + 1];
			enemy3BulletRightY[x] = enemy3BulletRightY[x + 1];
		}
		bulletCountRightEnemy3--;
	}

	// move the bullet of enemy4 to Right

	// Enemy4
	public static void moveBulletRightEnemy4()
	{
		for (int x = 0; x < bulletCountRightEnemy4; x++)
		{
			char next = getcharatxy((short)(enemy4BulletRightX[x] + 1), (short)enemy4BulletRightY[x]);
			if (next != ' ')
			{
				eraseBulletRightEnemy4(enemy4BulletRightX[x], enemy4BulletRightY[x]);
				removeBulletfromArrayRightEnemy4(x);
			}
			else
			{
				eraseBulletRightEnemy4(enemy4BulletRightX[x], enemy4BulletRightY[x]);
				enemy4BulletRightX[x] = enemy4BulletRightX[x] + 1;
				printBulletRightEnemy4(enemy4BulletRightX[x], enemy4BulletRightY[x]);
			}
		}
	}

	public static void printBulletRightEnemy4(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletRightEnemy4(int x, int y)
	{

		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayRightEnemy4(int index)
	{
		for (int x = index; x < bulletCountRightEnemy4 - 1; x++)
		{
			enemy4BulletRightX[x] = enemy4BulletRightX[x + 1];
			enemy4BulletRightY[x] = enemy4BulletRightY[x + 1];
		}
		bulletCountRightEnemy4--;
	}

	// move the bullet of enemy 1 to left

	// BULLET Movement of Enemies to LEFT
	// Enemy 1
	public static void moveBulletLeftEnemy1()
	{
		for (int x = 0; x < bulletCountLeftEnemy1; x++)
		{
			char next = getcharatxy((short)(enemy1BulletLeftX[x] - 1), (short)enemy1BulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeftEnemy1(enemy1BulletLeftX[x], enemy1BulletLeftY[x]);
				removeBulletfromArrayLeftEnemy1(x);
			}
			else
			{
				eraseBulletLeftEnemy1(enemy1BulletLeftX[x], enemy1BulletLeftY[x]);
				enemy1BulletLeftX[x] = enemy1BulletLeftX[x] - 1;
				printBulletLeftEnemy1(enemy1BulletLeftX[x], enemy1BulletLeftY[x]);
			}
		}
	}

	public static void printBulletLeftEnemy1(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);
		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletLeftEnemy1(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayLeftEnemy1(int index)
	{
		for (int x = index; x < bulletCountLeftEnemy1 - 1; x++)
		{
			enemy1BulletLeftX[x] = enemy1BulletLeftX[x + 1];
			enemy1BulletLeftY[x] = enemy1BulletLeftY[x + 1];
		}
		bulletCountLeftEnemy1--;
	}

	// move the bullet of enemy 2 to left

	// Enemy2
	public static void moveBulletLeftEnemy2()
	{
		for (int x = 0; x < bulletCountLeftEnemy2; x++)
		{
			char next = getcharatxy((short)(enemy2BulletLeftX[x] - 1), (short)enemy2BulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeftEnemy2(enemy2BulletLeftX[x], enemy2BulletLeftY[x]);
				removeBulletfromArrayLeftEnemy2(x);
			}
			else
			{
				eraseBulletLeftEnemy2(enemy2BulletLeftX[x], enemy2BulletLeftY[x]);
				enemy2BulletLeftX[x] = enemy2BulletLeftX[x] - 1;
				printBulletLeftEnemy2(enemy2BulletLeftX[x], enemy2BulletLeftY[x]);
			}
		}
	}

	public static void printBulletLeftEnemy2(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);

		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletLeftEnemy2(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayLeftEnemy2(int index)
	{
		for (int x = index; x < bulletCountLeftEnemy2 - 1; x++)
		{
			enemy2BulletLeftX[x] = enemy2BulletLeftX[x + 1];
			enemy2BulletLeftY[x] = enemy2BulletLeftY[x + 1];
		}
		bulletCountLeftEnemy2--;
	}

	// move the bullet of enemy 3 to left

	// Enemy 3
	public static void moveBulletLeftEnemy3()
	{
		for (int x = 0; x < bulletCountLeftEnemy3; x++)
		{
			char next = getcharatxy((short)(enemy3BulletLeftX[x] - 1), (short)enemy3BulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeftEnemy3(enemy3BulletLeftX[x], enemy3BulletLeftY[x]);
				removeBulletfromArrayLeftEnemy3(x);
			}
			else
			{
				eraseBulletLeftEnemy3(enemy3BulletLeftX[x], enemy3BulletLeftY[x]);
				enemy3BulletLeftX[x] = enemy3BulletLeftX[x] - 1;
				printBulletLeftEnemy3(enemy3BulletLeftX[x], enemy3BulletLeftY[x]);
			}
		}
	}

	public static void printBulletLeftEnemy3(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);
		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletLeftEnemy3(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayLeftEnemy3(int index)
	{
		for (int x = index; x < bulletCountLeftEnemy3 - 1; x++)
		{
			enemy3BulletLeftX[x] = enemy3BulletLeftX[x + 1];
			enemy3BulletLeftY[x] = enemy3BulletLeftY[x + 1];
		}
		bulletCountLeftEnemy3--;
	}

	// move the bullet of enemy 4 to left

	// Enemy 4
	public static void moveBulletLeftEnemy4()
	{
		for (int x = 0; x < bulletCountLeftEnemy4; x++)
		{
			char next = getcharatxy((short)(enemy4BulletLeftX[x] - 1), (short)enemy4BulletLeftY[x]);
			if (next != ' ')
			{
				eraseBulletLeftEnemy4(enemy4BulletLeftX[x], enemy4BulletLeftY[x]);
				removeBulletfromArrayLeftEnemy4(x);
			}
			else
			{
				eraseBulletLeftEnemy4(enemy4BulletLeftX[x], enemy4BulletLeftY[x]);
				enemy4BulletLeftX[x] = enemy4BulletLeftX[x] - 1;
				printBulletLeftEnemy4(enemy4BulletLeftX[x], enemy4BulletLeftY[x]);
			}
		}
	}

	public static void printBulletLeftEnemy4(int x, int y)
	{
		SetConsoleTextAttribute(hConsole, bulletColour);
		gotoxy(x, y);
		Console.Write(enemyBulletName);
	}

	public static void eraseBulletLeftEnemy4(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	public static void removeBulletfromArrayLeftEnemy4(int index)
	{
		for (int x = index; x < bulletCountLeftEnemy4 - 1; x++)
		{
			enemy4BulletLeftX[x] = enemy4BulletLeftX[x + 1];
			enemy4BulletLeftY[x] = enemy4BulletLeftY[x + 1];
		}
		bulletCountLeftEnemy4--;
	}

	// print the status of the game

	public static void printStatus()
	{
		SetConsoleTextAttribute(hConsole, 10);
		gotoxy(109, 38);
		Console.Write(status);
	}

	// print the health of the main Character

	public static void printHealth()
	{
		SetConsoleTextAttribute(hConsole, 10);
		gotoxy(75, 38);
		Console.Write(healthCounter);
	}

	// print the Name of the Game

	public static void printGameName()
	{
		SetConsoleTextAttribute(hConsole, 2);
		gotoxy(18, 38);
		Console.Write(gameName);
	}

	public static void removeHealth()
	{
		healthCounter--;
	}

	public static string loginOption;

	// game Entrance
	public static void gameEntrance()
	{
		Console.Write("                                                                                                      ");
		Console.Write("\n");
		Console.Write("                                                                                                      ");
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                                                                                                      ");
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
	}

	// top header displays at the top

	public static void topHeader()
	{
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("                                                                                             ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("      ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("                                                                                             ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
	}

	// login menu

	public static string loginMenu()
	{
		string option;
		Console.Write("\n\n\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");
		Console.Write("1. Start the game\n");
		Console.Write("2. Instructions\n");
		Console.Write("3. Character Information\n");
		Console.Write("4. Exit the game\n\n\n");
		Console.Write("Choose your Option......  ");
		option = ConsoleInput.ReadToWhiteSpace(true);
		return option;
	}

	// menu 1 of the game the main working of the game

	public static void menu1()
	{
		bool isGameRunning = true;
		system("cls");
		printMaze();
		printCharacter();

		while (isGameRunning == true)
		{
			healthDecrement();
			printScore();
			if (GetAsyncKeyState(VK_LEFT))
			{
				moveMarioLeft();
			}
			if (GetAsyncKeyState(VK_RIGHT))
			{
				moveMarioRight();
			}

			if (GetAsyncKeyState(VK_UP))
			{
				moveMarioUp();
			}

			if (GetAsyncKeyState(VK_DOWN))
			{
				moveMarioDown();
			}

			if (GetAsyncKeyState(VK_SPACE))
			{
				generateBulletRight();
			}

			if (GetAsyncKeyState(VK_CONTROL))
			{
				generateBulletLeft();
			}

			if (GetAsyncKeyState(VK_TAB))
			{
				isGameRunning = false;
			}
			printHealth();
			if (healthCounter < 0)
			{
				isGameRunning = false;
			}

			if (timer == 3)
			{
				if (enemy1Health > 0)
				{
					moveEnemy1();
				}
				else if (enemy1Health == 0)
				{
					eraseEnemy1();
					winningCount++;
				}

				if (enemy2Health > 0)
				{
					moveEnemy2();
				}
				else if (enemy2Health == 0)
				{
					eraseEnemy2();
					winningCount++;
				}

				if (enemy3Health > 0)
				{
					moveEnemy3();
				}
				else if (enemy3Health == 0)
				{
					eraseEnemy3();
					winningCount++;
				}

				if (enemy4Health > 0)
				{
					moveEnemy4();
				}
				else if (enemy4Health == 0)
				{
					eraseEnemy4();
					winningCount++;
				}

				timer = 0;
			}

			if (winningCount == 4)
			{
				break;
			}
			generateLift1();
			generateLift2();
			generateLift3();
			generateLift4();
			generateLift5();
			generateLift6();
			generateLift7();

			printStatus();
			printGameName();

			moveBulletRight();
			bulletCollisionWithEnemyRight();
			moveBulletLeft();
			bulletCollisionWithEnemyLeft();

			moveBulletRightEnemy1();
			moveBulletLeftEnemy1();

			moveBulletRightEnemy2();
			moveBulletLeftEnemy2();

			moveBulletRightEnemy3();
			moveBulletLeftEnemy3();

			moveBulletRightEnemy4();
			moveBulletLeftEnemy4();

			healthDecrement();
			timer++;
			Sleep(100);
		}

		if (healthCounter < 0)
		{
			topHeader();
			Console.Write("\n\n\n\n");
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write(a);
			Console.Write("\n");
			Console.Write("\n\n");
			Console.Write("You Lost the Game!\n");
			Console.Write("\n");
			getCharacter();
			getCharacter();
		}
	}

	// menu 2 of the game to show the instructions

	public static void menu2()
	{
		topHeader();
		Console.Write("\n\n\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");
		Console.Write("1. Move the Arrow Up Key to move UP");
		Console.Write("\n");
		Console.Write("2. Move the Arrow Down Key to move DOWN");
		Console.Write("\n");
		Console.Write("3. Move the Arrow Right Key to move RIGHT");
		Console.Write("\n");
		Console.Write("4. Move the Arrow Down Key to move LEFT");
		Console.Write("\n");
		Console.Write("5. Press Space Key to fire Bullet from right side");
		Console.Write("\n");
		Console.Write("6. Press Control Key to fire Bullet from left side");
		Console.Write("\n");
		Console.Write("7. Character can only move UP and DOWN with Stairs");
		Console.Write("\n");
		Console.Write("8. Character can have only 3 Healths");
		Console.Write("\n");
		Console.Write("9. The Score can be seen at the bottom(middle) of the screen");
		Console.Write("\n");
		getCharacter();
	}

	// Menu 3 of the game for Character Information

	public static void menu3()
	{
		topHeader();
		Console.Write("\n\n\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");
		Console.Write("Main Character :\n\n");
		for (int i = 0; i < 5; i++)
		{
			Console.Write(character1[i]);
		}
		Console.Write("\n");

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character2[i]);
		}
		Console.Write("\n");

		for (int i = 0; i < 5; i++)
		{
			Console.Write(character3[i]);
		}

		Console.Write("\n\n\n");

		Console.Write("Enemy # 1 :\n\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy1[index]);
		}
		Console.Write("\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy2[index]);
		}

		Console.Write("\n\n\n");

		Console.Write("Enemy # 2 :\n\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy1[index]);
		}
		Console.Write("\n");

		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy2[index]);
		}

		Console.Write("\n\n\n");

		Console.Write("Enemy # 3 :\n\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e3nemy1[index]);
		}
		Console.Write("\n");

		for (int index = 0; index < 6; index++)
		{
			Console.Write(e3nemy2[index]);
		}

		Console.Write("\n\n\n");

		Console.Write("Enemy # 4 :\n\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e4nemy1[index]);
		}
		Console.Write("\n");
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e4nemy2[index]);
		}
		Console.Write("\n");

		getCharacter();
	}

	public static void getCharacter()
	{
		Console.Write("\n\n\n");
		Console.Write("Press any key to continue.......");
		Console.ReadKey(true);
	}

	//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void healthDecrement();
	public static void winningInterface()
	{
		Console.Write("\n\n\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
	}

	//            character variables
	public static int pX = 6;
	public static int pY = 32;

	public static int[] bulletRightX = new int[100];
	public static int[] bulletRightY = new int[100];
	public static int bulletCountRight = 0;

	public static int[] bulletLeftX = new int[100];
	public static int[] bulletLeftY = new int[100];
	public static int bulletCountLeft = 0;

	// BULLET variables for Enemies RIGHT
	// Enemy 1
	public static int[] enemy1BulletRightX = new int[100];
	public static int[] enemy1BulletRightY = new int[100];
	public static int bulletCountRightEnemy1 = 0;
	// Enemy 2
	public static int[] enemy2BulletRightX = new int[100];
	public static int[] enemy2BulletRightY = new int[100];
	public static int bulletCountRightEnemy2 = 0;
	// Enemy 3
	public static int[] enemy3BulletRightX = new int[100];
	public static int[] enemy3BulletRightY = new int[100];
	public static int bulletCountRightEnemy3 = 0;
	// Enemy 4
	public static int[] enemy4BulletRightX = new int[100];
	public static int[] enemy4BulletRightY = new int[100];
	public static int bulletCountRightEnemy4 = 0;

	// BULLET variables for Enemies LEFT
	// Enemy 1
	public static int[] enemy1BulletLeftX = new int[100];
	public static int[] enemy1BulletLeftY = new int[100];
	public static int bulletCountLeftEnemy1 = 0;
	// Enemy 2
	public static int[] enemy2BulletLeftX = new int[100];
	public static int[] enemy2BulletLeftY = new int[100];
	public static int bulletCountLeftEnemy2 = 0;
	// Enemy 3
	public static int[] enemy3BulletLeftX = new int[100];
	public static int[] enemy3BulletLeftY = new int[100];
	public static int bulletCountLeftEnemy3 = 0;
	// Enemy 4
	public static int[] enemy4BulletLeftX = new int[100];
	public static int[] enemy4BulletLeftY = new int[100];
	public static int bulletCountLeftEnemy4 = 0;

	public static int e1nemyX = 60;
	public static int e1nemyY = 5;

	public static int e2nemyX = 12;
	public static int e2nemyY = 19;

	public static int e3nemyX = 45;
	public static int e3nemyY = 26;

	public static int e4nemyX = 109;
	public static int e4nemyY = 19;

	// for the draw of maze
	public static char box1 = 219;
	public static char box2 = 177;
	public static char box3 = 178;

	public static char left_character = 174;
	public static char right_character = 175;
	public static char box = 219;
	public static char emoji = 2;
	public static char a = 219;
	public static char lift = 22;
	public static int healthCounter = 100;

	public static char enemyBulletName = 15;
	public static int bulletColour = 13;

	public static int timer = 0;

	public static string enemyDirection1 = "Left";
	public static string enemyDirection2 = "Left";
	public static string enemyDirection3 = "Left";
	public static string enemyDirection4 = "Left";

	public static int score = 0;

	public static string status = "Playing";
	public static string gameName = "FAST MANIA";

	//           main character
	public static char[] character1 = { ' ', ' ', emoji, ' ', ' ' };
	public static char[] character2 = { left_character, box, box, box, right_character };
	public static char[] character3 = { '_', box, ' ', box, '_' };

	//           enemy 1
	public static char[] e1nemy1 = { '<', '_', box, box, '_', '>' };
	public static char[] e1nemy2 = { ' ', '0', ' ', ' ', '0', ' ' };

	//           enemy 2
	public static char[] e2nemy1 = { '<', '_', box, box, '_', '>' };
	public static char[] e2nemy2 = { ' ', '0', ' ', ' ', '0', ' ' };

	//           enemy 3
	public static char[] e3nemy1 = { '<', '_', box, box, '_', '>' };
	public static char[] e3nemy2 = { ' ', '0', ' ', ' ', '0', ' ' };

	//           enemy 4
	public static char[] e4nemy1 = { '<', '_', box, box, '_', '>' };
	public static char[] e4nemy2 = { ' ', '0', ' ', ' ', '0', ' ' };

	public static int enemy1Health = 50;
	public static int enemy2Health = 50;
	public static int enemy3Health = 50;
	public static int enemy4Health = 50;

	public static int winningCount = 0;

	//             main function

	static int Main()
	{

		while (loginOption != "4")
		{
			if (winningCount == 4)
			{
				system("cls");
				topHeader();
				winningInterface();
				getCharacter();
				break;
			}
			system("cls");
			gameEntrance();
			Console.ReadKey();
			system("cls");
			topHeader();
			loginOption = loginMenu();
			system("cls");
			if (loginOption == "1")
			{

				menu1();
			}

			else if (loginOption == "2")
			{
				menu2();
			}

			else if (loginOption == "3")
			{
				menu3();
			}

			else if (loginOption != "1" || loginOption != "2" || loginOption != "3" || loginOption != "4")
			{
				topHeader();
				Console.Write("\n\n\n\n");
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write(a);
				Console.Write("\n");
				Console.Write("\n\n");
				Console.Write("Thanks for Playing Fast Mania\n");
			}
			storeCoordinates();
			storeHealth();
			storeScore();
		}
	}




	static int Main()
	{
		Console.Write("     ***********************************************************                                                                                                                                  ");
		Console.Write("\n");
		Console.Write("   **************************************************************                                                                                                                                 ");
		Console.Write("\n");
		Console.Write(" ***************************************************************                                                                                                                                  ");
		Console.Write("\n");
		Console.Write(" *************************************************************                                                                                                                                    ");
		Console.Write("\n");
		Console.Write(" ************                                                                                                                                                                                     ");
		Console.Write("\n");
		Console.Write(" **********                                                                                                                                                                                       ");
		Console.Write("\n");
		Console.Write(" *********       ************                         ************       ******************     *****************    ******************    ******************                                     ");
		Console.Write("\n");
		Console.Write(" *********     ****************                     ****************    ********************   *******************   ******************   ********************                                    ");
		Console.Write("\n");
		Console.Write(" *********    ******************                   ******************   *******      *******   *******      ******         *******        *******      *******                                    ");
		Console.Write("\n");
		Console.Write(" *********    *******************                 *******************   *******      *******   *******      ******         *******        *******      *******                                    ");
		Console.Write("\n");
		Console.Write(" *********    *********** ********               ******** ***********   ********************   *******************         *******        *******      *******                                    ");
		Console.Write("\n");
		Console.Write(" *********    **********   ********             ********   **********   ********************   *******************         *******        *******      *******                                    ");
		Console.Write("\n");
		Console.Write(" *********    *********     ********           ********     *********   *******      *******   ******* *******             *******        *******      *******                                    ");
		Console.Write("\n");
		Console.Write(" *********    *********      ********         ********      *********   *******      *******   *******   *******           *******        *******      *******                                    ");
		Console.Write("\n");
		Console.Write(" *********    *********       ********       ********       *********   *******      *******   *******     *******   ******************   ********************                                    ");
		Console.Write("\n");
		Console.Write(" *********    *********        ********     ********        *********   *******      *******   *******      *******  ******************    ******************                                     ");
		Console.Write("\n");
		Console.Write(" *********    *********         ********   ********         *********                                                                                                                             ");
		Console.Write("\n");
		Console.Write(" *********    *********          ******** ********          *********                                                                                                                             ");
		Console.Write("\n");
		Console.Write(" *********    *********           ***************           *********                                                                                                                             ");
		Console.Write("\n");
		Console.Write(" *********    *********            *************            *********                                                                                                                             ");
		Console.Write("\n");
		Console.Write(" *********    *********             ***********             *********                                                                                                                             ");
		Console.Write("\n");
		Console.Write(" *********    *********                                     *********                                                                                                                             ");
		Console.Write("\n");
		Console.Write(" *********    *********                                     *********                                                                                                                             ");
		Console.Write("\n");
		Console.Write(" *********                                                                                                                                                                                        ");
		Console.Write("\n");
		Console.Write(" **********************************************************                                                                                                                                       ");
		Console.Write("\n");
		Console.Write(" *************************************************************                                                                                                                                    ");
		Console.Write("\n");
		Console.Write("  **************************************************************                                                                                                                                  ");
		Console.Write("\n");
		Console.Write("     ************************************************************                                                                                                                                 ");
		Console.Write("\n");
		Console.Write("                                                       ***********    ******************      ******               ******     *********************                                               ");
		Console.Write("\n");
		Console.Write("             *********            *****                 **********   ********************    *******    *******    *******   ***********************                                              ");
		Console.Write("\n");
		Console.Write("            ************         *******                 *********   *******      *******    *******    *******    *******   *******                                                              ");
		Console.Write("\n");
		Console.Write("            ******* *******      *******                 *********   *******      *******    *******    *******    *******   *******                                                              ");
		Console.Write("\n");
		Console.Write("            *******  *******     *******                 *********   *******      *******    *******    *******    *******    *******************                                                 ");
		Console.Write("\n");
		Console.Write("            *******    *******   *******                 *********   *******      *******    *******    *******    *******     ********************                                               ");
		Console.Write("\n");
		Console.Write("            *******     *******  *******                 *********   *******      *******    *******    *******    *******                   *******                                              ");
		Console.Write("\n");
		Console.Write("            *******      ******* *******                 *********   *******      *******    *******    *******    *******                   *******                                              ");
		Console.Write("\n");
		Console.Write("            *******         ************                 *********   ********************     ***************************    ***********************                                              ");
		Console.Write("\n");
		Console.Write("             *****           **********                 **********    ******************        ***********************       *********************                ");
		Console.Write("\n");
		Console.Write("                                                       ***********                                                                                                                                ");
		Console.Write("\n");
		Console.Write("    *************************************************************                                                                                                                                 ");
		Console.Write("\n");
		Console.Write("   *************************************************************                                                                                                                                  ");
		Console.Write("\n");
		Console.Write("  ************************************************************                                                                                                                                    ");
		Console.Write("\n");
		Console.Write("   ********************************************************                                                                                                                                       ");
		Console.Write("\n");
		Console.Write("                                                                                                                                                                                                  ");
		Console.Write("\n");
	}

	static int Main()
	{
		char a = 219;
		Console.Write("                                                                                                      ");
		Console.Write("\n");
		Console.Write("                                                                                                      ");
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("                ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("           ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("         ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                                                                                                      ");
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("                   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("        ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");

	}

	//--------------------------------------- Global Variables--------------------------------------//

	// Variables for Login Menu
	public static readonly int userArrSize = 10;
	public static string[] users = new string[userArrSize];
	public static string[] passwords = new string[userArrSize];
	public static string[] roles = new string[userArrSize];
	public static int usersCount = 0;

	// Variables for Product Detail
	public static string[] productBrand = new string[100];
	public static string[] productName = new string[100];
	public static string[] productCategory = new string[100];
	public static string[] productDetails = new string[100];
	public static float[] productPrice = new float[100];
	public static float[] productReviews = new float[100];
	public static int productCartNumber;

	// Variables for Shipping Details
	public static string nameShipping;
	public static string numberShipping;
	public static string cityShipping;
	public static string provinceShipping;
	public static string emailShipping;
	public static string shippingInfo;
	public static string billingInfo;
	public static float shippingFees = 150F;

	// Variable for Emoji Character
	public static char emoji = 2;

	// Variable for Shippment and Payment method
	public static int paymentMethods;
	public static int shippingCompany;
	public static string[] shipping = new string[100];
	public static string[] payment = new string[100];

	// Variables for Cart and Order Details
	public static int placeCart;
	public static int placeOrderedindex = 0;
	public static int reviewCount = 0;
	public static int orderPlacement = 0; // Order place hone k bad is me increment ho jaye ga jis se seller ki menu3 me addition ho jaye gi
	public static int productCount = 0;
	public static int cartCount = 0;
	public static int[] addToCartProducts = new int[100];
	public static int totalCheckout = 0;
	public static int numberOfProductsOrdered;
	public static int[] orderPlacedArray = new int[100];

	// Variable for Tracking Information
	public static int trackingNumber = 0;
	public static string inProgress = "No";
	public static string shipped = "No";
	public static string delivered = "No";

	// Variables for Discount
	public static string couponDiscount;
	public static float discountCouponPercentage;
	public static int numberOfItemsDiscount;
	public static float discountItemPercentage;
	public static int checkOutDiscount;
	public static float discountCheckOutPercentage;

	//------------------------------------User Defined Functions--------------------------------------//

	// functions for login Menu
	public static void topHeader()
	{
		char box = 219;
		{
			IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
			SetConsoleTextAttribute(hConsole, 12);

			Console.Write("                   ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("    ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write("           ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write("           ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("               ");
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write("           ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("             ");
			Console.Write(box);
			Console.Write("       ");
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write("           ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("             ");
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                   ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("    ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write("     ");
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write(box);
			Console.Write("\n");
			Console.Write("                                                                  ");
			Console.Write("\n");
			Console.Write("              ###############################################     ");
			Console.Write("\n");
			Console.Write("              ******** E-COMMERCE MANAGEMENT SYSTEM *********     ");
			Console.Write("\n");
			Console.Write("              ###############################################     ");
			Console.Write("\n");
			Console.Write("                         WELCOME TO E-COMMERCE SYSTEM             ");
			Console.Write("\n");
			Console.Write("\n");
		}
	}

	public static void subMenuBeforeMainMenu(string submenu)
	{
		string message = submenu + " Menu";
		Console.Write(message);
		Console.Write("\n");
		Console.Write("---------------------");
		Console.Write("\n");
		Console.Write("\n");
	}

	//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
	//void submenu();

	// signup function to get your ID
	public static bool signUp(string name, string password, string role)
	{
		if (usersCount < userArrSize)
		{
			users[usersCount] = name;
			passwords[usersCount] = password;
			roles[usersCount] = role;
			usersCount++;
			return true;
		}
		else
		{
			return false;
		}
	}

	// signin function

	public static string signIn(string name, string password)
	{
		for (int index = 0; index < usersCount; index++)
		{
			if (users[index] == name && passwords[index] == password)
			{
				return roles[index];
			}
		}
		return "undefined";
	}

	public static string loginMenu()
	{

		string option;
		Console.Write("1. SignUp to get you ID");
		Console.Write("\n");
		Console.Write("2. SignIn with your ID");
		Console.Write("\n");
		Console.Write("3. Exit the Application");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("Enter the Option Number >> ");
		option = ConsoleInput.ReadToWhiteSpace(true);

		return option;
		system("cls");
	}

	public static void clearScreen()
	{
		Console.Write("\n");
		Console.Write("Press Any Key to Continue..");
		Console.Write("\n");
		Console.ReadKey(true);

		system("cls");
	}

	// Seller Interface function

	// Functions for seller
	public static void sellerInterface()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 1);

		int sellerOption = 0;
		while (sellerOption != 10)
		{
			topHeader();
			subMenu("Seller");
			sellerOption = sellerMenu();

			if (sellerOption == 1)
			{
				// seller Menu1 = Product listing
				system("cls");
				topHeader();
				subMenu("List the Products");
				sellerMenu1();
				StoreSellerMenu1();
			}

			else if (sellerOption == 2)
			{
				// seller Menu2 = Search a Product
				system("cls");
				topHeader();
				subMenu("Search a Product");
				sellerMenu2();
			}

			else if (sellerOption == 3)
			{
				// seller Menu3 = Order Fulfillment
				system("cls");
				topHeader();
				subMenu("Order Fulfillment");
				sellerMenu3();
			}

			else if (sellerOption == 4)
			{
				// seller Menu4 = Remove Product
				system("cls");
				topHeader();
				subMenu("Remove Product");
				sellerMenu4();
				StoreSellerMenu4();
			}

			else if (sellerOption == 5)
			{
				// seller Menu5 = Update a Product
				system("cls");
				topHeader();
				subMenu("Update a Product");
				sellerMenu5();
				StoreSellerMenu5();
			}

			else if (sellerOption == 6)
			{
				// seller Menu6 = Show All Products
				system("cls");
				topHeader();
				subMenu("Show All Products");
				sellerMenu6();
			}

			else if (sellerOption == 7)
			{
				// seller Menu7 = Payment and Shipping
				system("cls");
				topHeader();
				subMenu("Payment and Shipping");
				sellerMenu7();
				StoreSellerMenu7();
			}

			else if (sellerOption == 8)
			{
				// seller Menu8 = Discount
				system("cls");
				topHeader();
				subMenu("Discount");
				sellerMenu8();
				StoreSellerMenu8();
			}

			else if (sellerOption == 9)
			{
				// seller Menu8 = Customer Support
				system("cls");
				topHeader();
				subMenu("Customer Support");
				sellerMenu9();
			}
			clearScreen();
		}
	}

	// All Seller Options

	public static int sellerMenu()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		int option;
		Console.Write("Select one of the following options number...");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("1\tList the Products");
		Console.Write("\n");
		Console.Write("2.\tSearch a Product");
		Console.Write("\n");
		Console.Write("3.\tOrder Fulfillment");
		Console.Write("\n");
		Console.Write("4.\tRemove a Product");
		Console.Write("\n");
		Console.Write("5.\tUpdate a Product");
		Console.Write("\n");
		Console.Write("6.\tShow All Products");
		Console.Write("\n");
		Console.Write("7.\tPayment and Shipping");
		Console.Write("\n");
		Console.Write("8.\tDiscounts");
		Console.Write("\n");
		Console.Write("9.\tCustomer Care");
		Console.Write("\n");
		Console.Write("10.\tExit");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("Your Option..");
		option = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

		return option;
	}

	//-----------------------CUSTOMER OPTION----------------------//

	// Functions for Customer
	public static void customerInterface()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 4);
		int customerOption = 0;
		while (customerOption != 10)
		{
			topHeader();
			subMenu("Customer");
			customerOption = customerMenu();

			//-----------Search a Product
			if (customerOption == 1)
			{
				system("cls");
				topHeader();
				subMenu("Search Product");
				customerMenu1();
			}

			//----------Product Under Budget
			if (customerOption == 2)
			{
				system("cls");
				topHeader();
				subMenu("Product Under Budget");
				customerMenu2();
			}

			//----------Add to cart
			if (customerOption == 3)
			{
				system("cls");
				topHeader();
				subMenu("Add to Cart");
				customerMenu3();
				StoreCustomerMenu3();
			}

			//----------Show Cart and Request Order
			if (customerOption == 4)
			{
				system("cls");
				topHeader();
				subMenu("Show Cart and Request Order");
				customerMenu4();
			}

			//----------Shipping Details
			if (customerOption == 5)
			{
				system("cls");
				topHeader();
				subMenu("Shipping Details");
				customerMenu5();
				StoreCustomerMenu5();
			}

			//----------Generate Bill
			if (customerOption == 6)
			{
				system("cls");
				topHeader();
				subMenu("Generate Bill");
				customerMenu6();
			}

			//----------Track Order
			if (customerOption == 7)
			{
				system("cls");
				topHeader();
				subMenu("Tack Order");
				customerMenu7();
				StoreCustomerMenu7();
			}

			//----------Give Review
			if (customerOption == 8)
			{
				system("cls");
				topHeader();
				subMenu("Give Review");
				customerMenu8();
			}

			//----------Customer Care
			if (customerOption == 9)
			{
				system("cls");
				topHeader();
				subMenu("Customer Care");
				customerMenu9();
			}

			clearScreen();
		}
	}

	// All customer Options

	public static int customerMenu()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		int option;
		Console.Write("Select one of the following options number...");
		Console.Write("\n");
		Console.Write("1. \tSearch Product");
		Console.Write("\n");
		Console.Write("2. \tProduct Under Budget");
		Console.Write("\n");
		Console.Write("3. \tAdd to Cart");
		Console.Write("\n");
		Console.Write("4. \tShow Cart and Request a Order");
		Console.Write("\n");
		Console.Write("5. \tShipping Details");
		Console.Write("\n");
		Console.Write("6. \tGenerate Bill");
		Console.Write("\n");
		Console.Write("7. \tTrack Order");
		Console.Write("\n");
		Console.Write("8. \tGive Review");
		Console.Write("\n");
		Console.Write("9. \tCustomer Care");
		Console.Write("\n");
		Console.Write("10. \tExit");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("Your Option...");
		option = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		return option;
	}

	// file handling for signUp function

	// file handling for Logins
	public static void storeUser(string userName, string password, string role)
	{
		fstream file = new fstream();
		file.open("signup.txt", ios.app);
		file << userName << "\n" << password << "\n" << role << "\n";
		file.close();
	}

	// file handling for load of signup

	public static void loadSignup()
	{
		fstream file = new fstream();
		string uName;
		string rolee;
		string pass;
		file.open("signup.txt", ios.@in);
		while (getline(file, uName) && getline(file, pass) && getline(file, rolee))
		{
			users[usersCount] = uName;
			passwords[usersCount] = pass;
			roles[usersCount] = rolee;
			usersCount++;
		}
		file.close();
	}

	//-----------------product Listing / Menu 1

	// Seller Menus
	public static void sellerMenu1()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 3);
		Console.Write("Enter the brand name       : ");
		cin.ignore();
		productBrand[productCount] = Console.ReadLine();

		Console.Write("Enter the product name     : ");
		productName[productCount] = Console.ReadLine();

		Console.Write("Enter the product category : ");
		productCategory[productCount] = Console.ReadLine();

		Console.Write("Enter the Price            : ");
		productPrice[productCount] = float.Parse(ConsoleInput.ReadToWhiteSpace(true));

		Console.Write("Enter the description      : ");
		cin.ignore();
		productDetails[productCount] = Console.ReadLine();

		Console.Write("Enter the Review           : ");
		productReviews[productCount] = float.Parse(ConsoleInput.ReadToWhiteSpace(true));

		productCount++;
	}

	//-----------------Product Search / Menu 2

	public static void sellerMenu2()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 4);
		if (productCount == 0)
		{
			Console.Write("There are no Poducts Yet(^.^)\n\n");
		}
		else
		{
			int productOption;
			for (int i = 0; i < productCount; i++)
			{
				Console.Write("Product ");
				Console.Write(i + 1);
				Console.Write(".");
				Console.Write(" ");
				Console.Write(productName[i]);
				Console.Write("\n");
			}
			Console.Write("\n");
			Console.Write("Enter the number of the product : ");
			productOption = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
			Console.Write("\n");
			for (int i = 0; i < productCount; i++)
			{
				if (productOption == i + 1)
				{
					Console.Write("Brand Name          : ");
					Console.Write(productBrand[i]);
					Console.Write("\n");
					Console.Write("Product Name        : ");
					Console.Write(productName[i]);
					Console.Write("\n");
					Console.Write("Product Price       : ");
					Console.Write(productPrice[i]);
					Console.Write("\n");
					Console.Write("Product Category    : ");
					Console.Write(productCategory[i]);
					Console.Write("\n");
					Console.Write("Product Reviews     : ");
					Console.Write(productReviews[i]);
					Console.Write("\n\n");
					Console.Write("Product Description : ");
					Console.Write(productDetails[i]);
					Console.Write("\n");
				}
			}
		}
	}

	//-----------------Order Fulfillment / Menu 3


	public static void sellerMenu3()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 5);

		int i = 0;
		if (trackingNumber == 1298)
		{
			Console.Write("Order # ");
			Console.Write(i + 1);
			Console.Write(" : \n");

			Console.Write("Enter the current **in Progress**  : ");
			inProgress = ConsoleInput.ReadToWhiteSpace(true);
			Console.Write("Enter the current **Shipped**      : ");
			shipped = ConsoleInput.ReadToWhiteSpace(true);
			Console.Write("Enter the current **Delivered**    : ");
			delivered = ConsoleInput.ReadToWhiteSpace(true);
		}

		if (trackingNumber == 0)
		{
			Console.Write("You have not any Orders yet.");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n\n");
		}
	}

	//-----------------Remove Product / Menu 4

	public static void sellerMenu4()
	{
		string removeProduct;
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 6);
		if (productCount == 0)
		{
			Console.Write("No Products Yet ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n\n");
		}
		else
		{
			Console.Write("Enter a product name : ");
			cin.ignore();
			removeProduct = Console.ReadLine();
			int index = 1000;
			index = sellerMenu4subMenu(removeProduct);
			while (index != 1000)
			{
				for (int i = index + 1; i < productCount; i++)
				{
					productBrand[i] = productBrand[i + 1];
					productName[i] = productName[i + 1];
					productCategory[i] = productCategory[i + 1];
					productPrice[i] = productPrice[i + 1];
					productDetails[i] = productDetails[i + 1];
					productReviews[i] = productReviews[i + 1];
				}
				productCount--;
				break;
			}

			if (index == 1000)
			{
				Console.Write("Invalid Product Name.");
				Console.Write("\n");
			}
		}
	}

	// SellMenu4 subMenu

	public static int sellerMenu4subMenu(string removeProduct)
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		int removeIndex = 1000;
		for (int i = 0; i < productCount; i++)
		{
			if (removeProduct == productName[i])
			{
				productBrand[i] = productBrand[i + 1];
				productName[i] = productName[i + 1];
				productCategory[i] = productCategory[i + 1];
				productPrice[i] = productPrice[i + 1];
				productDetails[i] = productDetails[i + 1];
				productReviews[i] = productReviews[i + 1];
				removeIndex = i;

				Sleep(200);
				Console.Write("\nWait until we are done....");
				Console.Write("\n");
				Console.Write("\n");
				Sleep(2000);
				Console.Write("REMOVED SUCCESSFULLY ");
				Console.Write("\n\n");

				break;
			}
		}

		return removeIndex;
	}

	//-----------------Update Product / Menu5

	public static void sellerMenu5()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 7);
		if (productCount == 0)
		{
			Console.Write("No Products Yet ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
		}
		else
		{
			int updateCount = 0;
			string updatedBrand;
			string searchProductName;
			string updatedName;
			string updatedCategory;
			string updatedDetails;
			int updatedPrice;
			float updatedReviews;

			Console.Write("Enter a product name : ");
			cin.ignore();
			searchProductName = Console.ReadLine();
			Console.Write("\n");
			for (int i = 0; i < productCount; i++)
			{
				if (searchProductName == productName[i])
				{
					Console.Write("Enter the new Product name       : ");
					updatedName = Console.ReadLine();
					productName[i] = updatedName;

					Console.Write("Enter the new Brand name         : ");
					updatedBrand = Console.ReadLine();
					productBrand[i] = updatedBrand;

					Console.Write("Enter the new Product Category   : ");
					updatedCategory = Console.ReadLine();
					productCategory[i] = updatedCategory;

					Console.Write("Enter the Price                  : ");
					updatedPrice = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
					productPrice[i] = updatedPrice;

					Console.Write("Enter the new Description        : ");
					cin.ignore();
					updatedDetails = Console.ReadLine();
					productDetails[i] = updatedDetails;

					Console.Write("Enter the new Review             : ");
					updatedReviews = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
					productReviews[i] = updatedReviews;
					IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
					SetConsoleTextAttribute(hConsole, 2);
					Sleep(2000);
					Console.Write("\n");
					Console.Write("\n");
					Console.Write("Done Successfully");
					Console.Write("\n");
					Console.Write("(^.^)");
					Console.Write("\n");
					Sleep(3000);

					updateCount++;
					break;
				}
			}
			if (updateCount == 0)
			{
				Console.Write("Invaid Product Name.");
				Console.Write("\n");
			}
		}
	}

	//-------------SellerMenu6 / Show All Product

	public static void sellerMenu6()
	{
		if (productCount == 0)
		{
			Console.Write("No Products Yet");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
		}
		else
		{
			for (int i = 0; i < productCount; i++)
			{
				Console.Write(i + 1);
				Console.Write(".\n");
				Console.Write("Brand Name          : ");
				Console.Write(productBrand[i]);
				Console.Write("\n");
				Console.Write("Product Name        : ");
				Console.Write(productName[i]);
				Console.Write("\n");
				Console.Write("Product Price       : ");
				Console.Write(productPrice[i]);
				Console.Write("\n");
				Console.Write("Product Category    : ");
				Console.Write(productCategory[i]);
				Console.Write("\n");
				Console.Write("Product Reviews     : ");
				Console.Write(productReviews[i]);
				Console.Write("\n\n");
				Console.Write("Product Description : ");
				Console.Write(productDetails[i]);
				Console.Write("\n");
				Console.Write("\n");
			}
		}
	}

	//-----------------Payment and Shipping / Menu 7

	public static void sellerMenu7()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 9);
		int shipCompany;
		int payMeth;
		Console.Write("How much Shipping Companies will you collaborate   : ");
		shipCompany = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("How much Payment Methods will you accept           : ");
		payMeth = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");

		paymentMethods = payMeth;
		shippingCompany = shipCompany;
		Console.Write("Payment Details ==> ");
		Console.Write("\n");
		cin.ignore();
		for (int i = 0; i < payMeth; i++)
		{
			Console.Write("Enter the ");
			Console.Write(i + 1);
			Console.Write(" Payment Method : ");

			payment[i] = Console.ReadLine();
		}

		Console.Write("\nShipping Details ==> ");
		Console.Write("\n");

		for (int i = 0; i < shipCompany; i++)
		{
			Console.Write("Enter the ");
			Console.Write(i + 1);
			Console.Write(" shipping company name : ");

			shipping[i] = Console.ReadLine();
		}
		Console.Write("\nPayment and Shipping Details : ");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("Payment Options : \n");
		for (int i = 0; i < payMeth; i++)
		{
			Console.Write(i + 1);
			Console.Write(". ");
			Console.Write(payment[i]);
			Console.Write("\n");
		}
		Console.Write("\n");

		Console.Write("Shipping Options : \n");
		for (int i = 0; i < shipCompany; i++)
		{
			Console.Write(i + 1);
			Console.Write(". ");
			Console.Write(shipping[i]);
			Console.Write("\n");
		}

		Console.Write("\n");
	}

	//-----------------Discounts / Menu 8

	public static void sellerMenu8()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 10);
		Console.Write("1.   Enter the number of items to give discount to customers : ");
		numberOfItemsDiscount = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

		Console.Write("     Enter the discount percentage for Items                 : ");
		discountItemPercentage = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		Console.Write("\n");

		Console.Write("2.   Enter the total Checkout to give Discount               : ");
		checkOutDiscount = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

		Console.Write("     Enter the discount percentage for Checkout              : ");
		discountCheckOutPercentage = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		Console.Write("\n");

		Console.Write("3.   Enter the Coupon Code to give Discounts                 : ");
		couponDiscount = ConsoleInput.ReadToWhiteSpace(true);
		Console.Write("     Enter the discount percentage for Coupons               : ");
		discountCouponPercentage = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		Console.Write("\n");

		Console.Write("DISCOUNT Details : \n");

		Console.Write("1.Buy ");
		Console.Write(numberOfItemsDiscount);
		Console.Write(" Items to AVAIL ");
		Console.Write(discountItemPercentage);
		Console.Write("% DISCOUNT.\n");
		Console.Write("2.CheckOut a Total of ");
		Console.Write(checkOutDiscount);
		Console.Write(" to AVAIL ");
		Console.Write(discountCheckOutPercentage);
		Console.Write("% DISCOUNT.\n");
		Console.Write("3.Apply ");
		Console.Write(couponDiscount);
		Console.Write(" as a Coupon at the checkout to AVAIL ");
		Console.Write(discountCouponPercentage);
		Console.Write("% DISCOUNT.\n");
	}

	//-----------------Customer Care / Menu 9

	public static void sellerMenu9()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 1);
		Console.Write("Q 1: How to remove a product ? \n");
		Console.Write("Q 2: How to accept the order of customer? \n");
		Console.Write("Q 3: How to give coupons to customers ? \n");
		Console.Write("Q 4: How to increase the products ? \n\n");
		Console.Write("Enter your query : ");
		int option;
		option = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n\n");
		sellerMenu9SubMenu1(option);
		sellerMenu9SubMenu2();
	}

	// SellerMenu9 Sub Menu

	public static void sellerMenu9SubMenu1(int option)
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		if (option == 1)
		{
			Console.Write("Select Option 4 from the seller menu and enter the product name and the product will be removed\n\n");
		}

		else if (option == 2)
		{
			Console.Write("Select Option 3 from the seller menu and accept the order of customer\n\n");
		}

		else if (option == 3)
		{
			Console.Write("Select Option 7 from the seller menu and enter the coupon name.\n\n");
		}

		else if (option == 4)
		{
			Console.Write("Select Option 1 from the seller menu and list your new products.\n\n");
		}

		else
		{
			Console.Write("Wait for the answer.. (^.^)\n\n");
		}
	}

	// SellerMenu9 Sub Menu

	public static void sellerMenu9SubMenu2()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		char answer;
		Console.Write("Are you Satisfied with the answer ?\n (Press Y for yes or Press N for no)");
		answer = ConsoleInput.ReadToWhiteSpace(true)[0];
		Console.Write("\n\n");
		if (answer == 'Y' || answer == 'y')
		{
			Console.Write("                                 ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("  Thanks for your Response  ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("                                 We are HAPPY to see your Response\n");
		}
		else if (answer == 'N' || answer == 'n')
		{

			Console.Write("                               ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("   Thanks for your Response   ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("                                   We will try better next time\n");
		}
	}

	// file handling SellerMenu1 for storing


	// Seller Menus File Handling
	public static void StoreSellerMenu1()
	{

		fstream file = new fstream();
		file.open("productDetails.txt", ios.@out);

		if (productCount != 0)
		{
			for (int i = 0; i < productCount; i++)

			{
				file << productBrand[i] << "\n";
				file << productName[i] << "\n";
				file << productCategory[i] << "\n";
				file << productPrice[i] << "\n";
				file << productDetails[i] << "\n";
				file << productReviews[i] << "\n";
			}
		}
		if (productCount == 0)
		{
			Console.Write("No Records yet.\n");
		}
		file.close();
	}

	// file handling SellerMenu1 for Loading

	public static void LoadSellerMenu1()
	{
		fstream file = new fstream();
		string prodBrand;
		string prodName;
		string prodCategory;
		string prodDetails;
		string prodPrice;
		string prodReviews;

		file.open("productDetails.txt", ios.@in);
		while ((getline(file, prodBrand)) && (getline(file, prodName)) && (getline(file, prodCategory)) && (getline(file, prodPrice)) && (getline(file, prodDetails)) && (getline(file, prodReviews)))
		{
			productBrand[productCount] = prodBrand;
			productName[productCount] = prodName;
			productCategory[productCount] = prodCategory;
			productDetails[productCount] = prodDetails;
			productPrice[productCount] = Convert.ToSingle(prodPrice);
			productReviews[productCount] = Convert.ToSingle(prodReviews);
			productCount++;
		}

		file.close();
	}

	// file handling for seller Menu4 Storing

	public static void StoreSellerMenu4()
	{
		fstream file = new fstream();

		file.open("productDetails.txt", ios.@out);
		for (int i = 0; i < productCount; i++)
		{

			file << productBrand[i] << "\n";
			file << productName[i] << "\n";
			file << productCategory[i] << "\n";
			file << productPrice[i] << "\n";
			file << productDetails[i] << "\n";
			file << productReviews[i] << "\n";
		}
	}

	// File Handling related to Seller Menu5 Storing

	public static void StoreSellerMenu5()
	{
		fstream file = new fstream();

		file.open("productDetails.txt", ios.@out);
		for (int i = 0; i < productCount; i++)
		{

			file << productBrand[i] << "\n";
			file << productName[i] << "\n";
			file << productCategory[i] << "\n";
			file << productPrice[i] << "\n";
			file << productDetails[i] << "\n";
			file << productReviews[i] << "\n";
		}
	}

	// File Handling for seller Menu7 for storing

	public static void StoreSellerMenu7()
	{
		fstream file = new fstream();
		file.open("shippingDetails.txt", ios.@out);
		for (int i = 0; i < shippingCompany; i++)
		{
			file << shipping[i] << "\n";
		}
		for (int i = 0; i < paymentMethods; i++)
		{
			file << payment[i] << "\n";
		}
		file.close();
	}

	// File Handling for seller Menu7 for loading

	public static void LoadSellerMenu7()
	{
		int count = 0;
		int counter = 0;
		fstream file = new fstream();
		string ship;
		string pay;
		file.open("shippingDetails.txt", ios.@in);
		while (getline(file, ship) && count != 3)
		{
			shipping[shippingCompany] = ship;
			count++;
		}
		while (getline(file, pay) && counter != 3)
		{
			payment[paymentMethods] = pay;
			counter++;
		}
		file.close();
	}

	// File Handling for seller Menu8 for storing

	public static void StoreSellerMenu8()
	{
		fstream file = new fstream();

		file.open("discounts.txt", ios.@out);
		file << numberOfItemsDiscount << "\n";
		file << discountItemPercentage << "\n";
		file << checkOutDiscount << "\n";
		file << discountCheckOutPercentage << "\n";
		file << couponDiscount << "\n";
		file << discountCouponPercentage << "\n";

		file.close();
	}

	// File Handling for seller Menu7 for Loading

	public static void LoadSellerMenu8()
	{
		fstream file = new fstream();
		string itemDis;
		string itemDisPercent;
		string checkoutDis;
		string checkoutDisPercent;
		string couponDis;
		string couponDisPercent;

		file.open("discounts.txt", ios.@in);
		while (getline(file, itemDis) && getline(file, itemDisPercent) && getline(file, checkoutDis) && getline(file, checkoutDisPercent) && getline(file, couponDis) && getline(file, couponDisPercent))
		{
			numberOfItemsDiscount = Convert.ToInt32(itemDis);
			discountItemPercentage = Convert.ToSingle(itemDisPercent);

			checkoutDis = Convert.ToInt32(checkoutDis);
			discountCheckOutPercentage = Convert.ToSingle(checkoutDisPercent);

			couponDiscount = couponDis;
			discountCouponPercentage = Convert.ToSingle(couponDisPercent);
		}
		file.close();
	}

	//---------------Search Product-------------//

	// Customer Menus
	public static void customerMenu1()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 4);
		if (productCount == 0)
		{
			Console.Write("No Product Found");
			Console.Write(emoji);
		}
		else
		{
			string searchProductName;

			Console.Write("Enter the Product Name : ");
			cin.ignore();
			searchProductName = Console.ReadLine();

			for (int i = 0; i < productCount; i++)
			{
				if (searchProductName == productName[i])
				{
					Console.Write(i + 1);
					Console.Write(".\n");
					Console.Write("Brand Name          : ");
					Console.Write(productBrand[i]);
					Console.Write("\n");
					Console.Write("Product Name        : ");
					Console.Write(productName[i]);
					Console.Write("\n");
					Console.Write("Product Price       : ");
					Console.Write(productPrice[i]);
					Console.Write("\n");
					Console.Write("Product Category    : ");
					Console.Write(productCategory[i]);
					Console.Write("\n");
					Console.Write("Product Reviews     : ");
					Console.Write(productReviews[i]);
					Console.Write("\n");
					Console.Write("Product Description : ");
					Console.Write(productDetails[i]);
					Console.Write("\n\n");
				}
			}

			Console.Write("\n\n");
		}
	}

	//---------------Product Under Budget-------------//

	public static void customerMenu2()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 5);
		int searchProductBudget;
		string productUnderBudgetName;
		Console.Write("Enter your Budget : ");
		searchProductBudget = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n");
		for (int i = 0; i < productCount; i++)
		{
			if (searchProductBudget >= productPrice[i])
			{
				Console.Write("Product ");
				Console.Write(i + 1);
				Console.Write(". ");
				Console.Write(productName[i]);
				Console.Write("\n");
			}
		}
		Console.Write("\n");
		Console.Write("Enter the product name to find its details : ");
		cin.ignore();
		productUnderBudgetName = Console.ReadLine();
		Console.Write("\n\n");

		for (int i = 0; i < productCount; i++)
		{
			if (productUnderBudgetName == productName[i])
			{
				Console.Write("Brand Name           : ");
				Console.Write(productBrand[i]);
				Console.Write("\n");
				Console.Write("Product Name         : ");
				Console.Write(productName[i]);
				Console.Write("\n");
				Console.Write("Product Price        : ");
				Console.Write(productPrice[i]);
				Console.Write("\n");
				Console.Write("Product Category     : ");
				Console.Write(productCategory[i]);
				Console.Write("\n");
				Console.Write("Product Reviews      : ");
				Console.Write(productReviews[i]);
				Console.Write("\n");
				Console.Write("Product Description  : ");
				Console.Write(productDetails[i]);
				Console.Write("\n");
			}
		}
	}

	//---------------Add to Cart-------------//


	public static void customerMenu3()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 6);

		char placeCartOption;
		string searchCartProductName;

		Console.Write("Enter the Product Name : ");
		cin.ignore();
		searchCartProductName = Console.ReadLine();
		Console.Write("\n\n");

		for (int i = 0; i < productCount; i++)
		{
			if (searchCartProductName == productName[i])
			{
				Console.Write(i + 1);
				Console.Write(".\n");
				Console.Write("Brand Name          : ");
				Console.Write(productBrand[i]);
				Console.Write("\n");
				Console.Write("Product Name        : ");
				Console.Write(productName[i]);
				Console.Write("\n");
				Console.Write("Product Price       : ");
				Console.Write(productPrice[i]);
				Console.Write("\n");
				Console.Write("Product Category    : ");
				Console.Write(productCategory[i]);
				Console.Write("\n");
				Console.Write("Product Reviews     : ");
				Console.Write(productReviews[i]);
				Console.Write("\n");
				Console.Write("Product Description : ");
				Console.Write(productDetails[i]);
				Console.Write("\n\n");

				Console.Write("Enter A to ADD TO CART or any other to continue......");
				placeCartOption = ConsoleInput.ReadToWhiteSpace(true)[0];
				if (placeCartOption == 'a' || placeCartOption == 'A')
				{
					Console.Write("Enter the product number to add to cart     : ");
					productCartNumber = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

					addToCartProducts[cartCount] = i;

					cartCount++;
				}
			}
		}
	}

	//---------------Show Cart and request a order-------------//

	public static void customerMenu4()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 7);
		int showCart;
		int indexNumber;
		char placeOrderOption;

		// for loop to show the cart
		for (int i = 0; i < cartCount; i++)
		{
			showCart = addToCartProducts[i];
			Console.Write(i + 1);
			Console.Write(".\n");
			Console.Write("Brand Name          : ");
			Console.Write(productBrand[showCart]);
			Console.Write("\n");
			Console.Write("Product Name        : ");
			Console.Write(productName[showCart]);
			Console.Write("\n");
			Console.Write("Product Price       : ");
			Console.Write(productPrice[showCart]);
			Console.Write("\n");
			Console.Write("Product Category    : ");
			Console.Write(productCategory[showCart]);
			Console.Write("\n");
			Console.Write("Product Reviews     : ");
			Console.Write(productReviews[showCart]);
			Console.Write("\n");
			Console.Write("Product Description : ");
			Console.Write(productDetails[showCart]);
			Console.Write("\n\n");
		}

		Console.Write("Press P to PLACE THE ORDER or press any key to continue : ");
		placeOrderOption = ConsoleInput.ReadToWhiteSpace(true)[0];
		if (placeOrderOption == 'P' || placeOrderOption == 'p')
		{
			Console.Write("Enter the number of products you want to order : ");
			numberOfProductsOrdered = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

			for (int i = 0; i < numberOfProductsOrdered; i++)
			{
				Console.Write("\nEnter the product number : ");
				indexNumber = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

				orderPlacedArray[i] = addToCartProducts[i];
				placeOrderedindex = addToCartProducts[indexNumber - 1];

				Console.Write("\nProduct Details ==> \n");
				Console.Write("Brand Name    : ");
				Console.Write(productBrand[placeOrderedindex]);
				Console.Write("\n");
				Console.Write("Product Name  : ");
				Console.Write(productName[placeOrderedindex]);
				Console.Write("\n");
				Console.Write("Product Price : ");
				Console.Write(productPrice[placeOrderedindex]);
				Console.Write("\n");
				Console.Write("\n");
				totalCheckout = (int)totalCheckout + productPrice[placeOrderedindex];
			}

			Console.Write("Now Add the Shipping Information and Generate the bill to CONFIRM THE ORDER.\n");

			Console.Write("\n");
		}
	}

	//---------------Shipping Details-------------//

	public static void customerMenu5()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 9);
		Console.Write("Enter your Name                    : ");
		cin.ignore();
		nameShipping = Console.ReadLine();
		Console.Write("Enter your Phone Number            : ");
		numberShipping = Console.ReadLine();
		Console.Write("Enter your city                    : ");
		cityShipping = Console.ReadLine();
		Console.Write("Enter your provice                 : ");
		provinceShipping = Console.ReadLine();
		Console.Write("Enter your E-mail address          : ");
		emailShipping = Console.ReadLine();
		Console.Write("Enter your Billing Information     : ");
		billingInfo = Console.ReadLine();
		Console.Write("Enter your Shipping Details here   : ");
		shippingInfo = Console.ReadLine();
	}

	//---------------Generate Bill-------------//

	public static void customerMenu6()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 10);
		string couponCode = "No";
		float totalCheckoutAfterDiscount;
		string pay;
		if (numberOfProductsOrdered == 0)
		{
			Console.Write("You have not Order any Product  Yet (^.^)\n");
		}
		else
		{
			trackingNumber = 1298;
			Console.Write("Your Order Details : \n");

			Console.Write("Your Details ==> \n\n");

			Console.Write("Your Shipping Fee      : ");
			Console.Write(shippingFees);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Your Name              : ");
			Console.Write(nameShipping);
			Console.Write("\n");
			Console.Write("Your Phone Number      : ");
			Console.Write(numberShipping);
			Console.Write("\n");
			Console.Write("Your Email Address     : ");
			Console.Write(emailShipping);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Bill to : ");
			Console.Write(billingInfo);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Ship to : ");
			Console.Write(shippingInfo);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write(nameShipping);
			Console.Write(" , ");
			Console.Write(numberShipping);
			Console.Write(" , ");
			Console.Write(cityShipping);
			Console.Write(" , ");
			Console.Write(provinceShipping);
			Console.Write(" , ");
			Console.Write(emailShipping);
			Console.Write("\n");
			Console.Write("\n");

			float bill = totalCheckout + (shippingFees * numberOfProductsOrdered);
			Console.Write("Your GENERATED BILL    : ");
			Console.Write(bill);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Enter the COUPON CODE Otherwise Enter No : ");
			cin.ignore();
			couponCode = Console.ReadLine();

			if (couponCode == couponDiscount)
			{
				float percent = ((discountCouponPercentage * bill) / 100);
				totalCheckoutAfterDiscount = bill - percent;
			}

			else if (numberOfProductsOrdered >= numberOfItemsDiscount)
			{
				float percent = ((discountItemPercentage * bill) / 100);
				totalCheckoutAfterDiscount = bill - percent;
			}
			else if (bill >= checkOutDiscount)
			{
				float percent = ((discountCheckOutPercentage * bill) / 100);
				totalCheckoutAfterDiscount = bill - percent;
			}

			else
			{
				totalCheckoutAfterDiscount = bill;
			}

			Console.Write("\n\nTOTAL CHECKOUT AFTER DISCOUNT : ");
			Console.Write(totalCheckoutAfterDiscount);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("Enter the Payment Method : ");
			pay = ConsoleInput.ReadToWhiteSpace(true);
			Console.Write("\n");
			Console.Write("\n");
			Console.Write("\n");
			Sleep(500);
			Console.Write("                        Wait Until Your ORDER is Placed.\n");
			Sleep(3000);
			Console.Write("                   ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("   Your ORDER has been placed SUCCESSFULLY   ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n\n\nYour Tracking number is : ");
			Console.Write(trackingNumber);
			Console.Write("\n");
		}
	}

	//---------------Track Order-------------//

	public static void customerMenu7()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 1);
		int track;
		Console.Write("Enter your Tracking Number : ");
		track = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		if (track == 1298)
		{
			Console.Write("Your Tracking Information : \n\n");
			Console.Write("Your Tracking Number      : ");
			Console.Write(track);
			Console.Write("\n\n");
			Console.Write("In Progress         : ");
			Console.Write(inProgress);
			Console.Write("\n");
			Console.Write("Shipped             : ");
			Console.Write(shipped);
			Console.Write("\n");
			Console.Write("Out for Delivery    : ");
			Console.Write(delivered);
			Console.Write("\n");
		}
		else
		{
			Console.Write("There are no records yet.Please enter a valid tracking number.\n");
		}
	}

	//---------------Give Review-------------//

	public static void customerMenu8()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		if (delivered == "yes")
		{
			for (int i = 0; i < numberOfProductsOrdered; i++)
			{
				int index = orderPlacedArray[i];
				Console.Write("\nProduct Name : ");
				Console.Write(productName[index]);
				Console.Write("\n");
				Console.Write("Give rating out of 5.0 : ");
				productReviews[index] = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
				Console.Write("\n");
			}
			Console.Write("\nThnks Alot for your response ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n\n");
		}
		else
		{
			Console.Write("There are no records yet.\n");
		}
	}

	//---------------Customer care-------------//

	public static void customerMenu9()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 3);
		Console.Write("Q 1: How to place the order ? \n");
		Console.Write("Q 2: How to have checkout discount ? \n");
		Console.Write("Q 3: How to apply Coupon Code ? \n");
		Console.Write("Q 4: how to apply price filter ? \n");
		Console.Write("Enter your query : ");
		int option;
		option = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		Console.Write("\n\n");
		customerMenu9SubMenu1(option);
		customerMenu9SubMenu2();
	}
	// customerMenu9 sub menu1


	public static void customerMenu9SubMenu1(int option)
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 4);
		if (option == 1)
		{
			Console.Write("Select Option 6 from the customer menu at the time of checkout\n\n");
		}

		else if (option == 2)
		{
			Console.Write("At Option 6,while generating the bill the discount will automatiocally be calculated.\n\n");
		}

		else if (option == 3)
		{
			Console.Write("Select Option 6,at the time of check out,enter the coupon code to avail discount.\n\n");
		}

		else if (option == 4)
		{
			Console.Write("Select Option 2 and appy your desired price filter.\n\n");
		}

		else
		{
			Console.Write("Wait for the answer..");
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("\n");
		}
	}

	// customerMenu9 sub menu2

	public static void customerMenu9SubMenu2()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 2);
		char answer;
		Console.Write("Are you Satisfied with the answer ?\n (Press Y for yes or Press N for no)");
		answer = ConsoleInput.ReadToWhiteSpace(true)[0];
		Console.Write("\n\n");
		if (answer == 'Y' || answer == 'y')
		{
			Console.Write("                                 ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("  Thanks for your Response  ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("                                 We are HAPPY to see your Response\n");
		}
		else if (answer == 'N' || answer == 'n')
		{

			Console.Write("                               ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("   Thanks for your Response   ");
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write(emoji);
			Console.Write("\n");
			Console.Write("                                   We will try better next time\n");
		}
	}

	//--------------File Handling for Customer Menu3 Storing

	// Customer Menus File Handling
	public static void StoreCustomerMenu3()
	{

		fstream file = new fstream();
		file.open("addToCartProducts.txt", ios.@out);
		for (int i = 0; i < cartCount; i++)
		{
			int index = addToCartProducts[i];
			file << index << "\n";
			file << productBrand[index] << "\n";
			file << productName[index] << "\n";
			file << productCategory[index] << "\n";
			file << productPrice[index] << "\n";
			file << productDetails[index] << "\n";
			file << productReviews[index] << "\n";
		}
		file.close();
	}

	//--------------File Handling for Customer Menu3 Loading

	public static void LoadCustomerMenu3()
	{
		fstream file = new fstream();
		string index;
		string proBrand;
		string proName;
		string proCategory;
		string proDetails;
		string proPrice;
		string proReviews;

		file.open("addToCartProducts.txt", ios.@in);
		while ((getline(file, index)) && (getline(file, proBrand)) && (getline(file, proName)) && (getline(file, proCategory)) && (getline(file, proPrice)) && (getline(file, proDetails)) && (getline(file, proReviews)))
		{
			addToCartProducts[cartCount] = Convert.ToInt32(index);
			productBrand[productCount] = proBrand;
			productName[productCount] = proName;
			productCategory[productCount] = proCategory;
			productDetails[productCount] = proDetails;
			productPrice[productCount] = Convert.ToSingle(proPrice);
			productReviews[productCount] = Convert.ToSingle(proReviews);
			productCount++;
			cartCount++;
		}

		file.close();
	}

	//---------------------File Handling for Customer Menu5 Storing

	public static void StoreCustomerMenu5()
	{
		fstream file = new fstream();
		file.open("shippingAddress.txt", ios.@out);
		file << nameShipping << "\n";
		file << numberShipping << "\n";
		file << cityShipping << "\n";
		file << provinceShipping << "\n";
		file << emailShipping << "\n";
		file << billingInfo << "\n";
		file << shippingInfo << "\n";
		file.close();
	}

	//---------------------File Handling for Customer Menu5 Load

	public static void LoadCustomerMenu5()
	{
		fstream file = new fstream();
		file.open("shippingAddress.txt", ios.@in);
		string nameShip;
		string numberShip;
		string cityShip;
		string provinceShip;
		string emailShip;
		string billInfo;
		string shipInfo;
		while ((getline(file, nameShip)) && (getline(file, numberShip)) && (getline(file, cityShip)) && (getline(file, provinceShip)) && (getline(file, emailShip)) && (getline(file, billInfo)) && (getline(file, shipInfo)))
		{
			nameShipping = nameShip;
			numberShipping = numberShip;
			cityShipping = cityShip;
			provinceShipping = provinceShip;
			emailShipping = emailShip;
			billingInfo = billInfo;
			shippingInfo = shippingInfo;
		}
		file.close();
	}

	//--------------------File Handling for Customer Menu 7 Storing

	public static void StoreCustomerMenu7()
	{
		fstream file = new fstream();
		file.open("TrackingInformation.txt", ios.@out);
		file << inProgress << "\n";
		file << shipped << "\n";
		file << delivered << "\n";
		file.close();
	}

	public static void LoadCustomerMenu7()
	{
		fstream file = new fstream();
		string inProg;
		string shipped;
		string deli;
		file.open("TrackingInformation.txt", ios.@in);
		while (getline(file, inProg) && getline(file, shipped) && getline(file, delivered))
		{
			inProgress = inProg;
			shipped = shipped;
			delivered = delivered;
		}
		file.close();
	}

	// MAIN FUNCTION----------------------------------------------------------------//
	static int Main()
	{
		system("cls");
		string loginOption;
		// load all the functions from the file
		loadSignup();
		LoadSellerMenu1();
		LoadSellerMenu7();
		LoadSellerMenu8();
		LoadCustomerMenu3();
		LoadCustomerMenu5();
		LoadCustomerMenu7();

		while (loginOption != "3")
		{
			topHeader();
			subMenuBeforeMainMenu("Login");
			loginOption = loginMenu();

			if (loginOption == "1")
			{ // signup option Interface
				system("cls");
				string name;
				string password;
				string role;
				Console.Write("\n");
				topHeader();
				subMenuBeforeMainMenu("SignUp");
				Console.Write("Enter your Name     : ");
				Console.Write("\n");
				name = ConsoleInput.ReadToWhiteSpace(true);
				Console.Write("Enter your Password : ");
				Console.Write("\n");
				password = ConsoleInput.ReadToWhiteSpace(true);
				Console.Write("Enter your Role     : ");
				Console.Write("\n");
				role = ConsoleInput.ReadToWhiteSpace(true);
				bool isValid = signUp(name, password, role);

				if (isValid)
				{
					storeUser(name, password, role);
					IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
					SetConsoleTextAttribute(hConsole, 2);
					Console.Write("SignedUp Successfully\n\n");
				}
				if (!isValid)
				{
					Console.Write("Users in the System have exceeded the Capacity");
					Console.Write("\n");
				}
				clearScreen();
			}

			else if (loginOption == "2")
			{
				// Sign in interface

				system("cls");
				string name;
				string password;
				string role;
				topHeader();
				subMenuBeforeMainMenu("SignIn");
				Console.Write("Enter your Name: ");
				Console.Write("\n");
				name = ConsoleInput.ReadToWhiteSpace(true);
				Console.Write("Enter your Password: ");
				Console.Write("\n");
				password = ConsoleInput.ReadToWhiteSpace(true);
				role = signIn(name, password);

				if (role == "Seller")
				{
					clearScreen();
					sellerInterface();
				}

				else if (role == "Customer")
				{
					clearScreen();
					customerInterface();
				}
				else if (role == "undefined")
				{
					Console.Write("You Entered wrong Credentials");
					Console.Write("\n");
					clearScreen();
				}
			}

			else if (loginOption == "3")
			{
			}

			else
			{

				Console.Write("Invalid login option");
				Console.Write("\n");
				clearScreen();
			}
		}
	}

	public static void subMenu(string submenu)
	{
		string message = "Main Menu > " + submenu;
		Console.Write(message);
		Console.Write("\n");
		Console.Write("---------------------");
		Console.Write("\n");
		Console.Write("\n");
	}

	public static char box = 219;
	public static char[] tank1 = { box, box, box, '-', '-', '>' };
	public static char[] tank2 = { '0', ' ', '0', ' ', ' ', ' ' };

	public static char[] e1nemy1 = { ' ', ' ', ' ', '-', '-', '-' };
	public static char[] e1nemy2 = { '<', '=', '=', '(', '-', ')' };
	public static char[] e1nemy3 = { ' ', ' ', ' ', '\\', '@', '/' };
	public static char[] e1nemy4 = { ' ', ' ', ' ', '*', '*', '*' };

	public static char[] e2nemy1 = { ' ', ' ', ' ', '-', '-', '-' };
	public static char[] e2nemy2 = { '<', '=', '=', '(', '-', ')' };
	public static char[] e2nemy3 = { ' ', ' ', ' ', '\\', '@', '/' };
	public static char[] e2nemy4 = { ' ', ' ', ' ', '*', '*', '*' };

	public static int[] bulletX = new int[100];
	public static int[] bulletY = new int[100];
	public static int bulletCount = 0;

	public static int tankX = 5;
	public static int tankY = 5;

	public static int e1nemyX = 30;
	public static int e1nemyY = 10;

	public static int e2nemyX = 20;
	public static int e2nemyY = 10;

	public static string enemyDirection1 = "Up";
	public static string enemyDirection2 = "Down";

	public static int timer1 = 0;
	public static int timer2 = 0;

	public static int score = 0;

	public static void gotoxy(int x, int y)
	{
		COORD coordinates = new COORD();
		coordinates.X = x;
		coordinates.Y = y;
		SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), coordinates);
	}

	public static char getCharAtxy(short x, short y)
	{
		CHAR_INFO ci = new CHAR_INFO();
		COORD xy = new COORD(0, 0);
		SMALL_RECT rect = new SMALL_RECT(x, y, x, y);
		COORD coordBufSize = new COORD();
		coordBufSize.X = 1;
		coordBufSize.Y = 1;
		return ReadConsoleOutput(GetStdHandle(STD_OUTPUT_HANDLE), ci, coordBufSize, xy, rect) ? ci.Char.AsciiChar : ' ';
	}

	public static void printTank()
	{
		gotoxy(tankX, tankY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(tank1[index]);
		}
		gotoxy(tankX, tankY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(tank2[index]);
		}
	}

	public static void eraseTank()
	{
		gotoxy(tankX, tankY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(tankX, tankY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	public static void printMaze()
	{
		Console.Write("############################################################################");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("#                                                                          #");
		Console.Write("\n");
		Console.Write("############################################################################");
		Console.Write("\n");
	}

	public static void moveBullet()
	{
		for (int x = 0; x < bulletCount; x++)
		{
			char next = getCharAtxy((short)(bulletX[x] + 1), (short)bulletY[x]);
			if (next != ' ')
			{
				eraseBullet(bulletX[x], bulletY[x]);
				removeBulletFromArray(x);
			}
			else
			{
				eraseBullet(bulletX[x], bulletY[x]);
				bulletX[x] = bulletX[x] + 1;
				printBullet(bulletX[x], bulletY[x]);
			}
		}
	}

	public static void generateBullet()
	{
		bulletX[bulletCount] = tankX + 7;
		bulletY[bulletCount] = tankY;
		gotoxy(tankX + 7, tankY);
		Console.Write(".");
		bulletCount++;
	}

	public static void removeBulletFromArray(int index)
	{
		for (int x = index; x < bulletCount - 1; x++)
		{
			bulletX[x] = bulletX[x + 1];
			bulletY[x] = bulletY[x + 1];
		}
		bulletCount--;
	}

	public static void moveTankUp()
	{
		char next = getCharAtxy((short)tankX, (short)(tankY - 1));
		if (next == ' ')
		{
			eraseTank();
			tankY = tankY - 1;
			printTank();
		}
	}

	public static void moveTankDown()
	{
		char next = getCharAtxy((short)tankX, (short)(tankY + 2));
		if (next == ' ')
		{
			eraseTank();
			tankY = tankY + 1;
			printTank();
		}
	}

	public static void moveTankLeft()
	{
		char next = getCharAtxy((short)(tankX - 1), (short)tankY);
		if (next == ' ')
		{
			eraseTank();
			tankX = tankX - 1;
			printTank();
		}
	}

	public static void moveTankRight()
	{
		char next = getCharAtxy((short)(tankX + 6), (short)tankY);
		if (next == ' ')
		{
			eraseTank();
			tankX = tankX + 1;
			printTank();
		}
	}

	public static void moveEnemy1()
	{

		if (enemyDirection1 == "Up")
		{
			char next = getCharAtxy((short)e1nemyX, (short)(e1nemyY - 1));
			if (next == ' ')
			{
				eraseEnemy1();
				e1nemyY--;
				printEnemy1();
				generateBulletEnemy1();
			}
			if (next == '#')
			{
				enemyDirection1 = "Down";
			}
		}
		if (enemyDirection1 == "Down")
		{
			char next = getCharAtxy((short)e1nemyX, (short)(e1nemyY + 4));
			if (next == ' ')
			{
				eraseEnemy1();
				e1nemyY = e1nemyY + 1;
				printEnemy1();
			}
			if (next == '#')
			{
				enemyDirection1 = "Up";
			}
		}
	}

	// for enemy2

	public static void moveEnemy2()
	{

		if (enemyDirection2 == "Up")
		{
			char next = getCharAtxy((short)e2nemyX, (short)(e2nemyY - 1));
			if (next == ' ')
			{
				eraseEnemy2();
				e2nemyY--;
				printEnemy2();
			}
			if (next == '#')
			{
				enemyDirection2 = "Down";
			}
		}
		if (enemyDirection2 == "Down")
		{
			char next = getCharAtxy((short)e2nemyX, (short)(e2nemyY + 4));
			if (next == ' ')
			{
				eraseEnemy2();
				e2nemyY = e2nemyY + 1;
				printEnemy2();
			}
			if (next == '#')
			{
				enemyDirection2 = "Up";
			}
		}
	}

	public static void generateBulletEnemy1()
	{

		gotoxy(e1nemyX - 1, e1nemyY);
		Console.Write(".");

	}

	public static void generateBulletEnemy2()
	{

		gotoxy(e2nemyX - 1, e2nemyY);
		Console.Write(".");

	}

	public static void printEnemy1()
	{
		gotoxy(e1nemyX, e1nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy1[index]);
		}
		gotoxy(e1nemyX, e1nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy2[index]);
		}
		gotoxy(e1nemyX, e1nemyY + 2);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy3[index]);
		}
		gotoxy(e1nemyX, e1nemyY + 3);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e1nemy4[index]);
		}
	}

	// print enemy2


	public static void printEnemy2()
	{
		gotoxy(e2nemyX, e2nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy1[index]);
		}
		gotoxy(e2nemyX, e2nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy2[index]);
		}
		gotoxy(e2nemyX, e2nemyY + 2);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy3[index]);
		}
		gotoxy(e2nemyX, e2nemyY + 3);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(e2nemy4[index]);
		}
	}

	public static void eraseEnemy1()
	{
		gotoxy(e1nemyX, e1nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e1nemyX, e1nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e1nemyX, e1nemyY + 2);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e1nemyX, e1nemyY + 3);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	// erase enemy2

	public static void eraseEnemy2()
	{
		gotoxy(e2nemyX, e2nemyY);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e2nemyX, e2nemyY + 1);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e2nemyX, e2nemyY + 2);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
		gotoxy(e2nemyX, e2nemyY + 3);
		for (int index = 0; index < 6; index++)
		{
			Console.Write(" ");
		}
	}

	public static void addScore()
	{
		score++;
	}

	public static void printScore()
	{
		gotoxy(65, 8);
		Console.Write("Score: ");
		Console.Write(score);
	}

	public static void bulletCollisionWithEnemy()
	{
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		for (int x = 0; x < bulletCount; x++)
		{
			if (bulletX[x] + 1 == e1nemyX && (bulletY[x] == e1nemyY || bulletY[x] == e1nemyY + 1 || bulletY[x] == e1nemyY + 2 || bulletY[x] == e1nemyY + 3))
			{
				addScore();
				eraseBullet(bulletX[x], bulletY[x]);
				removeBulletFromArray(x);
			}

			if (bulletX[x] + 1 == e2nemyX && (bulletY[x] == e2nemyY || bulletY[x] == e2nemyY + 1 || bulletY[x] == e2nemyY + 2 || bulletY[x] == e2nemyY + 3))
			{
				addScore();
				eraseBullet(bulletX[x], bulletY[x]);
				removeBulletFromArray(x);
			}
		}
	}

	public static void printBullet(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(".");
	}

	public static void eraseBullet(int x, int y)
	{
		gotoxy(x, y);
		Console.Write(" ");
	}

	static int Main()
	{
		system("cls");
		IntPtr hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
		SetConsoleTextAttribute(hConsole, 6);
		printMaze();
		printTank();
		printEnemy1();
		while (true)
		{
			printScore();
			if (GetAsyncKeyState(VK_LEFT))
			{
				moveTankLeft();
			}
			if (GetAsyncKeyState(VK_RIGHT))
			{
				moveTankRight();
			}
			if (GetAsyncKeyState(VK_UP))
			{
				moveTankUp();
			}
			if (GetAsyncKeyState(VK_DOWN))
			{
				moveTankDown();
			}
			if (GetAsyncKeyState(VK_SPACE))
			{
				generateBullet();
			}

			if (timer1 == 3)
			{
				moveEnemy1();
				generateBulletEnemy1();
				moveEnemy2();
				generateBulletEnemy2();
				timer1 = 0;
			}
			moveBullet();
			bulletCollisionWithEnemy();
			timer1++;

			Sleep(90);
		}
	}

	public static char[] square = { 'o', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
	/*********************************************
		FUNCTION TO RETURN GAME STATUS

		1 FOR GAME IS OVER WITH RESULT
		-1 FOR GAME IS IN PROGRESS
		O GAME IS OVER AND NO RESULT
	**********************************************/

	public static int checkwin()
	{
		if (square[1] == square[2] && square[2] == square[3])
		{
			return 1;
		}
		else if (square[4] == square[5] && square[5] == square[6])
		{
			return 1;
		}
		else if (square[7] == square[8] && square[8] == square[9])
		{
			return 1;
		}
		else if (square[1] == square[4] && square[4] == square[7])
		{
			return 1;
		}
		else if (square[2] == square[5] && square[5] == square[8])
		{
			return 1;
		}
		else if (square[3] == square[6] && square[6] == square[9])
		{
			return 1;
		}
		else if (square[1] == square[5] && square[5] == square[9])
		{
			return 1;
		}
		else if (square[3] == square[5] && square[5] == square[7])
		{
			return 1;
		}
		else if (square[1] != '1' && square[2] != '2' && square[3] != '3' && square[4] != '4' && square[5] != '5' && square[6] != '6' && square[7] != '7' && square[8] != '8' && square[9] != '9')
		{
			return 0;
		}
		else
		{
			return -1;
		}
	}

	public static void board()
	{
		system("cls");
		Console.Write("\n\n\tTic Tac Toe\n\n");
		Console.Write("\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");

		Console.Write("Player 1 = X\n");
		Console.Write("Player 2 = O");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("\n");
		Console.Write("     |     |     ");
		Console.Write("\n");
		Console.Write("  ");
		Console.Write(square[1]);
		Console.Write("  |  ");
		Console.Write(square[2]);
		Console.Write("  |  ");
		Console.Write(square[3]);
		Console.Write("\n");
		Console.Write("_____|_____|_____");
		Console.Write("\n");
		Console.Write("     |     |     ");
		Console.Write("\n");
		Console.Write("  ");
		Console.Write(square[4]);
		Console.Write("  |  ");
		Console.Write(square[5]);
		Console.Write("  |  ");
		Console.Write(square[6]);
		Console.Write("\n");
		Console.Write("_____|_____|_____");
		Console.Write("\n");
		Console.Write("     |     |     ");
		Console.Write("\n");
		Console.Write("  ");
		Console.Write(square[7]);
		Console.Write("  |  ");
		Console.Write(square[8]);
		Console.Write("  |  ");
		Console.Write(square[9]);
		Console.Write("\n");
		Console.Write("     |     |     ");
		Console.Write("\n");
		Console.Write("\n");
	}

	static int Main()
	{
		int player = 1;
		int i;
		int choice;
		char mark;
		do
		{
			board();
			player = (player % 2) != 0 ? 1 : 2;
			Console.Write("Enter a number for Player ");
			Console.Write(player);
			Console.Write(" : ");
			choice = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
			mark = (player == 1) ? 'X' : 'O';
			if (choice == 1 && square[1] == '1')
			{
				square[1] = mark;
			}
			else if (choice == 2 && square[2] == '2')
			{
				square[2] = mark;
			}
			else if (choice == 3 && square[3] == '3')
			{
				square[3] = mark;
			}
			else if (choice == 4 && square[4] == '4')
			{
				square[4] = mark;
			}
			else if (choice == 5 && square[5] == '5')
			{
				square[5] = mark;
			}
			else if (choice == 6 && square[6] == '6')
			{
				square[6] = mark;
			}
			else if (choice == 7 && square[7] == '7')
			{
				square[7] = mark;
			}
			else if (choice == 8 && square[8] == '8')
			{
				square[8] = mark;
			}
			else if (choice == 9 && square[9] == '9')
			{
				square[9] = mark;
			}
			else
			{
				Console.Write("\nInvalid\n");
				player--;
				cin.ignore();
				Console.Read();
			}
			i = checkwin();
			player++;
		} while (i == -1);
		board();
		if (i == 1)
		{
			Console.Write("Player ");
			Console.Write(--player);
			Console.Write(" Wins ");
		}
		else
		{
			Console.Write("Game Draw");
		}
		cin.ignore();
		Console.Read();
		return 0;
	}

	/*******************************************************************
	     FUNCTION TO DRAW BOARD OF TIC TAC TOE WITH PLAYERS MARK
	********************************************************************/

	public static char a = 219;

	/*******************************************************************
	                END OF PROJECT
	********************************************************************/
	public static char a = 219;
	public static char box2 = 177;
	public static void winningInterface()
	{
		Console.Write("\n\n\n\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("\n\n");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("   ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write("\n");
		Console.Write("  ");
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
	}

	public static void topHeader()
	{
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("                                                                                             ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("      ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write("       ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("      ");
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write("   ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("   ");
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("  ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(a);
		Console.Write(" ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("    ");
		Console.Write(a);
		Console.Write(a);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("                                                                                             ");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write(box2);
		Console.Write("\n");
	}
	public static void getCharacter()
	{
		Console.Write("\n\n\n");
		Console.Write("Press any key to continue.......");
		Console.ReadKey(true);
	}
	static int Main()
	{
		system("cls");
		topHeader();
		winningInterface();
		getCharacter();
	}

}