﻿namespace Discuz.Album.Data
{
    public class DbProvider
    {
        private static readonly DataProvider _dp = new DataProvider();
        private DbProvider()
        { }

        public static DataProvider GetInstance()
        {
            return _dp;
        }

    }
}
