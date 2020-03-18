using System.Threading.Tasks;

namespace Layak.Client.Interface.Hud.Elements
{
	public abstract class Element
	{
		protected readonly HudManager Manager;

		protected Element(HudManager manager)
		{
			this.Manager = manager;
		}

		public abstract Task Render();
	}
}
