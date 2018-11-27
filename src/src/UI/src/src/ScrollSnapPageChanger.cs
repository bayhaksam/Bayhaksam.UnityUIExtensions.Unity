//-----------------------------------------------------------------------
// <copyright file="ScrollSnapPageChanger.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.UnityUIExtensions.Unity.UI
{
	using UnityEngine;
	using UnityEngine.UI.Extensions;

	public class ScrollSnapPageChanger : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		ScrollSnapBase scrollSnap;

		[SerializeField]
		int page;
		#endregion

		#region Properties
		public ScrollSnapBase ScrollSnap
		{
			get { return this.scrollSnap; }
			set { this.scrollSnap = value; }
		}

		public int Page
		{
			get { return this.page; }
			set { this.page = value; }
		}
		#endregion

		#region Public Methods
		public void Change()
		{
			if (this.Page != this.ScrollSnap.CurrentPage)
			{
				this.ScrollSnap.ChangePage(this.Page);
			}
		}

		public void Change(int page)
		{
			if (this.Page != this.ScrollSnap.CurrentPage)
			{
				this.ScrollSnap.ChangePage(page);
			}
		}
		#endregion
	}
}
