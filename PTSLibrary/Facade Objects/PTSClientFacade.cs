﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary.Facade_Objects
{
	class PTSClientFacade : PTSSuperFacade
	{
		private DAO.ClientDAO dao;

		public PTSClientFacade() : base(new DAO.ClientDAO())
		{
			dao = (dao.ClientDAO)base.dao;
		}

		public TeamLeader Authenticate(string username, string password)
		{
			if (username == "" || password == "")
			{
				throw new Exception("Missing Data");
			}
			return dao.Authenticate(username, password);
		}

		public Project[] GetListOfProjects(int teamId)
		{
			return (dao.GetListOfProjects(teamId)).ToArray;
		}

	}
}
