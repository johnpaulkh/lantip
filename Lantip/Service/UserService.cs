using Lantip.Connection;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading;
using Dapper;
using Lantip.Model;

namespace Lantip.Service
{
	class UserService
	{
		/// <summary>
		/// Conection used by this service
		/// </summary>
		SQLiteConnection sqlConnection = new DatabaseConnection().GetConnection();

		/// <summary>
		/// indicator that the login is accepted
		/// </summary>
		public static int LOGIN_OK = 0;
		/// <summary>
		/// indicator that the login is failed
		/// </summary>
		public static int LOGIN_WRONG = -1;

		/// <summary>
		/// Check login based on username and password
		/// </summary>
		/// <param name="username">user's username</param>
		/// <param name="password">user's password</param>
		/// <returns>login indicator <see cref="UserService.LOGIN_OK"/></returns>
		public int CheckLogin(String username, String password)
		{
			if(sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
			var query = @"select count(*) from user where username = '" + username + "' and password = '" + password + "'";
			using (var sqlCommand = new SQLiteCommand(query, sqlConnection))
			{
				Int64 result = (Int64)sqlCommand.ExecuteScalar();
				if (result == 0) return LOGIN_WRONG;
			}
			sqlConnection.Close();
			return LOGIN_OK;
		}

		public User GetUser(String username)
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

			var query = @"select username, password, nama, tipeUser from User where username = @username";
			var users = sqlConnection.Query<User>(query, new { username });

			sqlConnection.Close();

			return users.ToList()[0];
		}

	}
}
