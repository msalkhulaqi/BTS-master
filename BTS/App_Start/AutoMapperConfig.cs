﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;

namespace BTS
{
	public static class AutoMapperConfig
	{
		public static void RegisterMappings()
		{
			// Add map creation statements here
			// Mapper.CreateMap< FROM , TO >();

			// Disable AutoMapper v4.2.x warnings
#pragma warning disable CS0618

			// AutoMapper create map statements

			Mapper.CreateMap<Models.RegisterViewModel, Models.RegisterViewModelForm>();

			// Add more below...





#pragma warning restore CS0618
		}
	}
}