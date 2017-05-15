﻿//
//   		Copyright 2017 KeyleXiao.
//     		Contact : Keyle_xiao@hotmail.com 
//
//     		Licensed under the Apache License, Version 2.0 (the "License");
//     		you may not use this file except in compliance with the License.
//     		You may obtain a copy of the License at
//
//     		http://www.apache.org/licenses/LICENSE-2.0
//
//     		Unless required by applicable law or agreed to in writing, software
//     		distributed under the License is distributed on an "AS IS" BASIS,
//     		WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     		See the License for the specific language governing permissions and
//     		limitations under the License.
//
using System;
namespace SmartDataViewer.Editor
{
	public enum WindowType
	{
		INPUT,
		CALLBACK
	}
	public class IMultipleWindow : UnityEditor.EditorWindow
	{
		protected WindowType current_windowType = WindowType.INPUT;
		protected Action<object, object> select_callback { get; set; }
		protected object current_list { get; set; }

		public virtual void UpdateSelectModel(object curren_list, Action<object, object> callback) { }
	}
}
