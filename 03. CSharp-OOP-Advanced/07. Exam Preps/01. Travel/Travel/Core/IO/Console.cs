﻿using System;

public static class Console
{
	public static void WriteLine(string input)
	{
		System.Console.WriteLine(input);
	}

    public static void Write(string input)
    {
        System.Console.Write(input);
    }
}

public class Int32
{
	public static int Parse(string format)
	{
		throw new FormatException("Input string was not in a correct format.");
	}
}