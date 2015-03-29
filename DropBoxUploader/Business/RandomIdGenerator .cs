﻿using System;
using System.Text;

namespace DropBoxUploader.Business
{
	static class RandomIdGenerator
	{
		private static readonly char[] _base62chars =
		"0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
		.ToCharArray();

		private static readonly Random _random = new Random();

		public static string GetBase62(int length)
		{
			var sb = new StringBuilder(length);

			for (int i = 0; i < length; i++)
				sb.Append(_base62chars[_random.Next(62)]);

			return sb.ToString();
		}

		public static string GetBase36(int length)
		{
			var sb = new StringBuilder(length);

			for (int i = 0; i < length; i++)
				sb.Append(_base62chars[_random.Next(36)]);

			return sb.ToString();
		}
	}
}
