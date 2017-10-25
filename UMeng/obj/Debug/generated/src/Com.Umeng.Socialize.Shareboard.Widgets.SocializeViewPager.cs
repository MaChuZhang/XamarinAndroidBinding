using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Shareboard.Widgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']"
	[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/widgets/SocializeViewPager", DoNotGenerateAcw=true)]
	public partial class SocializeViewPager : global::Android.Views.ViewGroup {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/field[@name='SCROLL_STATE_DRAGGING']"
		[Register ("SCROLL_STATE_DRAGGING")]
		public const int ScrollStateDragging = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/field[@name='SCROLL_STATE_IDLE']"
		[Register ("SCROLL_STATE_IDLE")]
		public const int ScrollStateIdle = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/field[@name='SCROLL_STATE_SETTLING']"
		[Register ("SCROLL_STATE_SETTLING")]
		public const int ScrollStateSettling = (int) 2;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager.ItemInfo']"
		[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/widgets/SocializeViewPager$ItemInfo", DoNotGenerateAcw=true)]
		public partial class ItemInfo : global::Java.Lang.Object {

			protected ItemInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager.LayoutParams']"
		[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/widgets/SocializeViewPager$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams {


			static IntPtr gravity_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager.LayoutParams']/field[@name='gravity']"
			[Register ("gravity")]
			public int Gravity {
				get {
					if (gravity_jfieldId == IntPtr.Zero)
						gravity_jfieldId = JNIEnv.GetFieldID (class_ref, "gravity", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, gravity_jfieldId);
				}
				set {
					if (gravity_jfieldId == IntPtr.Zero)
						gravity_jfieldId = JNIEnv.GetFieldID (class_ref, "gravity", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, gravity_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr isDecor_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager.LayoutParams']/field[@name='isDecor']"
			[Register ("isDecor")]
			public bool IsDecor {
				get {
					if (isDecor_jfieldId == IntPtr.Zero)
						isDecor_jfieldId = JNIEnv.GetFieldID (class_ref, "isDecor", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isDecor_jfieldId);
				}
				set {
					if (isDecor_jfieldId == IntPtr.Zero)
						isDecor_jfieldId = JNIEnv.GetFieldID (class_ref, "isDecor", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isDecor_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/shareboard/widgets/SocializeViewPager$LayoutParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LayoutParams); }
			}

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager.LayoutParams']/constructor[@name='SocializeViewPager.LayoutParams' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe LayoutParams ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager.LayoutParams']/constructor[@name='SocializeViewPager.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (LayoutParams)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/interface[@name='SocializeViewPager.OnPageChangeListener']"
		[Register ("com/umeng/socialize/shareboard/widgets/SocializeViewPager$OnPageChangeListener", "", "Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager/IOnPageChangeListenerInvoker")]
		public partial interface IOnPageChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/interface[@name='SocializeViewPager.OnPageChangeListener']/method[@name='onPageScrollStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onPageScrollStateChanged", "(I)V", "GetOnPageScrollStateChanged_IHandler:Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager/IOnPageChangeListenerInvoker, UMeng")]
			void OnPageScrollStateChanged (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/interface[@name='SocializeViewPager.OnPageChangeListener']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
			[Register ("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler:Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager/IOnPageChangeListenerInvoker, UMeng")]
			void OnPageScrolled (int p0, float p1, int p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/interface[@name='SocializeViewPager.OnPageChangeListener']/method[@name='onPageSelected' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onPageSelected", "(I)V", "GetOnPageSelected_IHandler:Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager/IOnPageChangeListenerInvoker, UMeng")]
			void OnPageSelected (int p0);

		}

		[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/widgets/SocializeViewPager$OnPageChangeListener", DoNotGenerateAcw=true)]
		internal class IOnPageChangeListenerInvoker : global::Java.Lang.Object, IOnPageChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/shareboard/widgets/SocializeViewPager$OnPageChangeListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnPageChangeListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnPageChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPageChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.shareboard.widgets.SocializeViewPager.OnPageChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPageChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPageScrollStateChanged_I;
#pragma warning disable 0169
			static Delegate GetOnPageScrollStateChanged_IHandler ()
			{
				if (cb_onPageScrollStateChanged_I == null)
					cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageScrollStateChanged_I);
				return cb_onPageScrollStateChanged_I;
			}

			static void n_OnPageScrollStateChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageScrollStateChanged (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPageScrollStateChanged_I;
			public unsafe void OnPageScrollStateChanged (int p0)
			{
				if (id_onPageScrollStateChanged_I == IntPtr.Zero)
					id_onPageScrollStateChanged_I = JNIEnv.GetMethodID (class_ref, "onPageScrollStateChanged", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrollStateChanged_I, __args);
			}

			static Delegate cb_onPageScrolled_IFI;
#pragma warning disable 0169
			static Delegate GetOnPageScrolled_IFIHandler ()
			{
				if (cb_onPageScrolled_IFI == null)
					cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, int>) n_OnPageScrolled_IFI);
				return cb_onPageScrolled_IFI;
			}

			static void n_OnPageScrolled_IFI (IntPtr jnienv, IntPtr native__this, int p0, float p1, int p2)
			{
				global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageScrolled (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onPageScrolled_IFI;
			public unsafe void OnPageScrolled (int p0, float p1, int p2)
			{
				if (id_onPageScrolled_IFI == IntPtr.Zero)
					id_onPageScrolled_IFI = JNIEnv.GetMethodID (class_ref, "onPageScrolled", "(IFI)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrolled_IFI, __args);
			}

			static Delegate cb_onPageSelected_I;
#pragma warning disable 0169
			static Delegate GetOnPageSelected_IHandler ()
			{
				if (cb_onPageSelected_I == null)
					cb_onPageSelected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnPageSelected_I);
				return cb_onPageSelected_I;
			}

			static void n_OnPageSelected_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPageSelected (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPageSelected_I;
			public unsafe void OnPageSelected (int p0)
			{
				if (id_onPageSelected_I == IntPtr.Zero)
					id_onPageSelected_I = JNIEnv.GetMethodID (class_ref, "onPageSelected", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageSelected_I, __args);
			}

		}

		public partial class PageScrollStateChangedEventArgs : global::System.EventArgs {

			public PageScrollStateChangedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		public partial class PageScrolledEventArgs : global::System.EventArgs {

			public PageScrolledEventArgs (int p0, float p1, int p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}
		}

		public partial class PageSelectedEventArgs : global::System.EventArgs {

			public PageSelectedEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/umeng/socialize/shareboard/widgets/SocializeViewPager_OnPageChangeListenerImplementor")]
		internal sealed partial class IOnPageChangeListenerImplementor : global::Java.Lang.Object, IOnPageChangeListener {

			object sender;

			public IOnPageChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/umeng/socialize/shareboard/widgets/SocializeViewPager_OnPageChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PageScrollStateChangedEventArgs> OnPageScrollStateChangedHandler;
#pragma warning restore 0649

			public void OnPageScrollStateChanged (int p0)
			{
				var __h = OnPageScrollStateChangedHandler;
				if (__h != null)
					__h (sender, new PageScrollStateChangedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<PageScrolledEventArgs> OnPageScrolledHandler;
#pragma warning restore 0649

			public void OnPageScrolled (int p0, float p1, int p2)
			{
				var __h = OnPageScrolledHandler;
				if (__h != null)
					__h (sender, new PageScrolledEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<PageSelectedEventArgs> OnPageSelectedHandler;
#pragma warning restore 0649

			public void OnPageSelected (int p0)
			{
				var __h = OnPageSelectedHandler;
				if (__h != null)
					__h (sender, new PageSelectedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnPageChangeListenerImplementor value)
			{
				return value.OnPageScrollStateChangedHandler == null && value.OnPageScrolledHandler == null && value.OnPageSelectedHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager.PagerObserver']"
		[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/widgets/SocializeViewPager$PagerObserver", DoNotGenerateAcw=true)]
		public partial class PagerObserver : global::Android.Database.DataSetObserver {

			protected PagerObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/shareboard/widgets/SocializeViewPager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeViewPager); }
		}

		protected SocializeViewPager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/constructor[@name='SocializeViewPager' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe SocializeViewPager (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (SocializeViewPager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/constructor[@name='SocializeViewPager' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SocializeViewPager (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SocializeViewPager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/constructor[@name='SocializeViewPager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SocializeViewPager (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SocializeViewPager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/constructor[@name='SocializeViewPager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SocializeViewPager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SocializeViewPager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentItem;
#pragma warning disable 0169
		static Delegate GetGetCurrentItemHandler ()
		{
			if (cb_getCurrentItem == null)
				cb_getCurrentItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentItem);
			return cb_getCurrentItem;
		}

		static int n_GetCurrentItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentItem;
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentItem_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentItem_IHandler ()
		{
			if (cb_setCurrentItem_I == null)
				cb_setCurrentItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCurrentItem_I);
			return cb_setCurrentItem_I;
		}

		static void n_SetCurrentItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentItem = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentItem;
		static IntPtr id_setCurrentItem_I;
		public virtual unsafe int CurrentItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='getCurrentItem' and count(parameter)=0]"
			[Register ("getCurrentItem", "()I", "GetGetCurrentItemHandler")]
			get {
				if (id_getCurrentItem == IntPtr.Zero)
					id_getCurrentItem = JNIEnv.GetMethodID (class_ref, "getCurrentItem", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentItem);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentItem", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='setCurrentItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurrentItem", "(I)V", "GetSetCurrentItem_IHandler")]
			set {
				if (id_setCurrentItem_I == IntPtr.Zero)
					id_setCurrentItem_I = JNIEnv.GetMethodID (class_ref, "setCurrentItem", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentItem_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentItem", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetAddOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_Handler ()
		{
			if (cb_addOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ == null)
				cb_addOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_);
			return cb_addOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_;
		}

		static void n_AddOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener p0 = (global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOnPageChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='addOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.shareboard.widgets.SocializeViewPager.OnPageChangeListener']]"
		[Register ("addOnPageChangeListener", "(Lcom/umeng/socialize/shareboard/widgets/SocializeViewPager$OnPageChangeListener;)V", "GetAddOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_Handler")]
		public virtual unsafe void AddOnPageChangeListener (global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener p0)
		{
			if (id_addOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ == IntPtr.Zero)
				id_addOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ = JNIEnv.GetMethodID (class_ref, "addOnPageChangeListener", "(Lcom/umeng/socialize/shareboard/widgets/SocializeViewPager$OnPageChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnPageChangeListener", "(Lcom/umeng/socialize/shareboard/widgets/SocializeViewPager$OnPageChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_arrowScroll_I;
#pragma warning disable 0169
		static Delegate GetArrowScroll_IHandler ()
		{
			if (cb_arrowScroll_I == null)
				cb_arrowScroll_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_ArrowScroll_I);
			return cb_arrowScroll_I;
		}

		static bool n_ArrowScroll_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ArrowScroll (p0);
		}
#pragma warning restore 0169

		static IntPtr id_arrowScroll_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='arrowScroll' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("arrowScroll", "(I)Z", "GetArrowScroll_IHandler")]
		public virtual unsafe bool ArrowScroll (int p0)
		{
			if (id_arrowScroll_I == IntPtr.Zero)
				id_arrowScroll_I = JNIEnv.GetMethodID (class_ref, "arrowScroll", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_arrowScroll_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "arrowScroll", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_canScroll_Landroid_view_View_ZIII;
#pragma warning disable 0169
		static Delegate GetCanScroll_Landroid_view_View_ZIIIHandler ()
		{
			if (cb_canScroll_Landroid_view_View_ZIII == null)
				cb_canScroll_Landroid_view_View_ZIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, int, int, int, bool>) n_CanScroll_Landroid_view_View_ZIII);
			return cb_canScroll_Landroid_view_View_ZIII;
		}

		static bool n_CanScroll_Landroid_view_View_ZIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3, int p4)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanScroll (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_canScroll_Landroid_view_View_ZIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='canScroll' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("canScroll", "(Landroid/view/View;ZIII)Z", "GetCanScroll_Landroid_view_View_ZIIIHandler")]
		protected virtual unsafe bool CanScroll (global::Android.Views.View p0, bool p1, int p2, int p3, int p4)
		{
			if (id_canScroll_Landroid_view_View_ZIII == IntPtr.Zero)
				id_canScroll_Landroid_view_View_ZIII = JNIEnv.GetMethodID (class_ref, "canScroll", "(Landroid/view/View;ZIII)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canScroll_Landroid_view_View_ZIII, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canScroll", "(Landroid/view/View;ZIII)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_clearOnPageChangeListeners;
#pragma warning disable 0169
		static Delegate GetClearOnPageChangeListenersHandler ()
		{
			if (cb_clearOnPageChangeListeners == null)
				cb_clearOnPageChangeListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearOnPageChangeListeners);
			return cb_clearOnPageChangeListeners;
		}

		static void n_ClearOnPageChangeListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearOnPageChangeListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_clearOnPageChangeListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='clearOnPageChangeListeners' and count(parameter)=0]"
		[Register ("clearOnPageChangeListeners", "()V", "GetClearOnPageChangeListenersHandler")]
		public virtual unsafe void ClearOnPageChangeListeners ()
		{
			if (id_clearOnPageChangeListeners == IntPtr.Zero)
				id_clearOnPageChangeListeners = JNIEnv.GetMethodID (class_ref, "clearOnPageChangeListeners", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearOnPageChangeListeners);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearOnPageChangeListeners", "()V"));
			} finally {
			}
		}

		static Delegate cb_executeKeyEvent_Landroid_view_KeyEvent_;
#pragma warning disable 0169
		static Delegate GetExecuteKeyEvent_Landroid_view_KeyEvent_Handler ()
		{
			if (cb_executeKeyEvent_Landroid_view_KeyEvent_ == null)
				cb_executeKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ExecuteKeyEvent_Landroid_view_KeyEvent_);
			return cb_executeKeyEvent_Landroid_view_KeyEvent_;
		}

		static bool n_ExecuteKeyEvent_Landroid_view_KeyEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ExecuteKeyEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_executeKeyEvent_Landroid_view_KeyEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='executeKeyEvent' and count(parameter)=1 and parameter[1][@type='android.view.KeyEvent']]"
		[Register ("executeKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetExecuteKeyEvent_Landroid_view_KeyEvent_Handler")]
		public virtual unsafe bool ExecuteKeyEvent (global::Android.Views.KeyEvent p0)
		{
			if (id_executeKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				id_executeKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID (class_ref, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_executeKeyEvent_Landroid_view_KeyEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeKeyEvent", "(Landroid/view/KeyEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayout_ZIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPageScrolled_IFI;
#pragma warning disable 0169
		static Delegate GetOnPageScrolled_IFIHandler ()
		{
			if (cb_onPageScrolled_IFI == null)
				cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, int>) n_OnPageScrolled_IFI);
			return cb_onPageScrolled_IFI;
		}

		static void n_OnPageScrolled_IFI (IntPtr jnienv, IntPtr native__this, int p0, float p1, int p2)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPageScrolled (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onPageScrolled_IFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='onPageScrolled' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler")]
		protected virtual unsafe void OnPageScrolled (int p0, float p1, int p2)
		{
			if (id_onPageScrolled_IFI == IntPtr.Zero)
				id_onPageScrolled_IFI = JNIEnv.GetMethodID (class_ref, "onPageScrolled", "(IFI)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPageScrolled_IFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPageScrolled", "(IFI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetRemoveOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_Handler ()
		{
			if (cb_removeOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ == null)
				cb_removeOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_);
			return cb_removeOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_;
		}

		static void n_RemoveOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener p0 = (global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnPageChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='removeOnPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.shareboard.widgets.SocializeViewPager.OnPageChangeListener']]"
		[Register ("removeOnPageChangeListener", "(Lcom/umeng/socialize/shareboard/widgets/SocializeViewPager$OnPageChangeListener;)V", "GetRemoveOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_Handler")]
		public virtual unsafe void RemoveOnPageChangeListener (global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener p0)
		{
			if (id_removeOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ == IntPtr.Zero)
				id_removeOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_ = JNIEnv.GetMethodID (class_ref, "removeOnPageChangeListener", "(Lcom/umeng/socialize/shareboard/widgets/SocializeViewPager$OnPageChangeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeOnPageChangeListener_Lcom_umeng_socialize_shareboard_widgets_SocializeViewPager_OnPageChangeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOnPageChangeListener", "(Lcom/umeng/socialize/shareboard/widgets/SocializeViewPager$OnPageChangeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_Handler ()
		{
			if (cb_setAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_ == null)
				cb_setAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_);
			return cb_setAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_;
		}

		static void n_SetAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.shareboard.widgets.SocializePagerAdapter']]"
		[Register ("setAdapter", "(Lcom/umeng/socialize/shareboard/widgets/SocializePagerAdapter;)V", "GetSetAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_Handler")]
		public virtual unsafe void SetAdapter (global::Com.Umeng.Socialize.Shareboard.Widgets.SocializePagerAdapter p0)
		{
			if (id_setAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_ == IntPtr.Zero)
				id_setAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_ = JNIEnv.GetMethodID (class_ref, "setAdapter", "(Lcom/umeng/socialize/shareboard/widgets/SocializePagerAdapter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdapter_Lcom_umeng_socialize_shareboard_widgets_SocializePagerAdapter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdapter", "(Lcom/umeng/socialize/shareboard/widgets/SocializePagerAdapter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCurrentItem_IZ;
#pragma warning disable 0169
		static Delegate GetSetCurrentItem_IZHandler ()
		{
			if (cb_setCurrentItem_IZ == null)
				cb_setCurrentItem_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetCurrentItem_IZ);
			return cb_setCurrentItem_IZ;
		}

		static void n_SetCurrentItem_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentItem_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard.widgets']/class[@name='SocializeViewPager']/method[@name='setCurrentItem' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setCurrentItem", "(IZ)V", "GetSetCurrentItem_IZHandler")]
		public virtual unsafe void SetCurrentItem (int p0, bool p1)
		{
			if (id_setCurrentItem_IZ == IntPtr.Zero)
				id_setCurrentItem_IZ = JNIEnv.GetMethodID (class_ref, "setCurrentItem", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentItem_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentItem", "(IZ)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener"
		public event EventHandler<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.PageScrollStateChangedEventArgs> PageScrollStateChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener, global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor>(
						ref weak_implementor_AddOnPageChangeListener,
						__CreateIOnPageChangeListenerImplementor,
						AddOnPageChangeListener,
						__h => __h.OnPageScrollStateChangedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener, global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor>(
						ref weak_implementor_AddOnPageChangeListener,
						global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor.__IsEmpty,
						__v => RemoveOnPageChangeListener (__v),
						__h => __h.OnPageScrollStateChangedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.PageScrolledEventArgs> PageScrolled {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener, global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor>(
						ref weak_implementor_AddOnPageChangeListener,
						__CreateIOnPageChangeListenerImplementor,
						AddOnPageChangeListener,
						__h => __h.OnPageScrolledHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener, global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor>(
						ref weak_implementor_AddOnPageChangeListener,
						global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor.__IsEmpty,
						__v => RemoveOnPageChangeListener (__v),
						__h => __h.OnPageScrolledHandler -= value);
			}
		}

		public event EventHandler<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.PageSelectedEventArgs> PageSelected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener, global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor>(
						ref weak_implementor_AddOnPageChangeListener,
						__CreateIOnPageChangeListenerImplementor,
						AddOnPageChangeListener,
						__h => __h.OnPageSelectedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListener, global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor>(
						ref weak_implementor_AddOnPageChangeListener,
						global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor.__IsEmpty,
						__v => RemoveOnPageChangeListener (__v),
						__h => __h.OnPageSelectedHandler -= value);
			}
		}

		WeakReference weak_implementor_AddOnPageChangeListener;

		global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor __CreateIOnPageChangeListenerImplementor ()
		{
			return new global::Com.Umeng.Socialize.Shareboard.Widgets.SocializeViewPager.IOnPageChangeListenerImplementor (this);
		}
#endregion
	}
}
