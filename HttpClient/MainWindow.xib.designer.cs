// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HttpClient {

	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[Foundation.Register("AppDelegate")]
	public partial class AppDelegate {

		private UIKit.UIWindow __mt_window;

		private UIKit.UIButton __mt_button1;

		private UIKit.UITableView __mt_stack;

		private UIKit.UINavigationController __mt_navigationController;

		#pragma warning disable 0169
		[Foundation.Connect("window")]
		private UIKit.UIWindow window {
			get {
				this.__mt_window = ((UIKit.UIWindow)(this.GetNativeField("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField("window", value);
			}
		}

		[Foundation.Connect("button1")]
		private UIKit.UIButton button1 {
			get {
				this.__mt_button1 = ((UIKit.UIButton)(this.GetNativeField("button1")));
				return this.__mt_button1;
			}
			set {
				this.__mt_button1 = value;
				this.SetNativeField("button1", value);
			}
		}

		[Foundation.Connect("stack")]
		private UIKit.UITableView stack {
			get {
				this.__mt_stack = ((UIKit.UITableView)(this.GetNativeField("stack")));
				return this.__mt_stack;
			}
			set {
				this.__mt_stack = value;
				this.SetNativeField("stack", value);
			}
		}

		[Foundation.Connect("navigationController")]
		private UIKit.UINavigationController navigationController {
			get {
				this.__mt_navigationController = ((UIKit.UINavigationController)(this.GetNativeField("navigationController")));
				return this.__mt_navigationController;
			}
			set {
				this.__mt_navigationController = value;
				this.SetNativeField("navigationController", value);
			}
		}
	}
}
