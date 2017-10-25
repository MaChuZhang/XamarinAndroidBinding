using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	[Register ("com/umeng/socialize/UMAuthListener", DoNotGenerateAcw=true)]
	public abstract class UMAuthListener : Java.Lang.Object {

		internal UMAuthListener ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMAuthListener']/field[@name='ACTION_AUTHORIZE']"
		[Register ("ACTION_AUTHORIZE")]
		public const int ActionAuthorize = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMAuthListener']/field[@name='ACTION_DELETE']"
		[Register ("ACTION_DELETE")]
		public const int ActionDelete = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMAuthListener']/field[@name='ACTION_GET_PROFILE']"
		[Register ("ACTION_GET_PROFILE")]
		public const int ActionGetProfile = (int) 2;
	}

	[Register ("com/umeng/socialize/UMAuthListener", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UMAuthListener' type. This type will be removed in a future release.")]
	public abstract class UMAuthListenerConsts : UMAuthListener {

		private UMAuthListenerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMAuthListener']"
	[Register ("com/umeng/socialize/UMAuthListener", "", "Com.Umeng.Socialize.IUMAuthListenerInvoker")]
	public partial interface IUMAuthListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMAuthListener']/method[@name='onCancel' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[2][@type='int']]"
		[Register ("onCancel", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;I)V", "GetOnAuthCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_IHandler:Com.Umeng.Socialize.IUMAuthListenerInvoker, UMeng")]
		void OnAuthCancel (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMAuthListener']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onComplete", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;ILjava/util/Map;)V", "GetOnAuthComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_Handler:Com.Umeng.Socialize.IUMAuthListenerInvoker, UMeng")]
		void OnAuthComplete (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1, global::System.Collections.Generic.IDictionary<string, string> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMAuthListener']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("onError", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;ILjava/lang/Throwable;)V", "GetOnAuthError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_Handler:Com.Umeng.Socialize.IUMAuthListenerInvoker, UMeng")]
		void OnAuthError (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1, global::Java.Lang.Throwable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMAuthListener']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("onStart", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", "GetOnAuthStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMAuthListenerInvoker, UMeng")]
		void OnAuthStart (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0);

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/UMAuthListener", DoNotGenerateAcw=true)]
	internal class IUMAuthListenerInvoker : global::Java.Lang.Object, IUMAuthListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/UMAuthListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUMAuthListenerInvoker); }
		}

		IntPtr class_ref;

		public static IUMAuthListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUMAuthListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.UMAuthListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUMAuthListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I;
#pragma warning disable 0169
		static Delegate GetOnAuthCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_IHandler ()
		{
			if (cb_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I == null)
				cb_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnAuthCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I);
			return cb_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I;
		}

		static void n_OnAuthCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Socialize.IUMAuthListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthCancel (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I;
		public unsafe void OnAuthCancel (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1)
		{
			if (id_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I == IntPtr.Zero)
				id_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I = JNIEnv.GetMethodID (class_ref, "onCancel", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_I, __args);
		}

		static Delegate cb_onComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnAuthComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_Handler ()
		{
			if (cb_onComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_ == null)
				cb_onComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnAuthComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_);
			return cb_onComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_;
		}

		static void n_OnAuthComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.IUMAuthListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthComplete (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_;
		public unsafe void OnAuthComplete (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_onComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_ == IntPtr.Zero)
				id_onComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;ILjava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnAuthError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_Handler ()
		{
			if (cb_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_ == null)
				cb_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnAuthError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_);
			return cb_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_;
		}

		static void n_OnAuthError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.IUMAuthListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthError (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_;
		public unsafe void OnAuthError (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1, global::Java.Lang.Throwable p2)
		{
			if (id_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;ILjava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_ILjava_lang_Throwable_, __args);
		}

		static Delegate cb_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetOnAuthStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAuthStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static void n_OnAuthStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.IUMAuthListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAuthStart (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		public unsafe void OnAuthStart (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "onStart", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
		}

	}

	public partial class AuthCancelEventArgs : global::System.EventArgs {

		public AuthCancelEventArgs (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0;
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	public partial class AuthCompleteEventArgs : global::System.EventArgs {

		public AuthCompleteEventArgs (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0;
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		global::System.Collections.Generic.IDictionary<string, string> p2;
		public global::System.Collections.Generic.IDictionary<string, string> P2 {
			get { return p2; }
		}
	}

	public partial class AuthErrorEventArgs : global::System.EventArgs {

		public AuthErrorEventArgs (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1, global::Java.Lang.Throwable p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0;
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		global::Java.Lang.Throwable p2;
		public global::Java.Lang.Throwable P2 {
			get { return p2; }
		}
	}

	public partial class AuthStartEventArgs : global::System.EventArgs {

		public AuthStartEventArgs (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			this.p0 = p0;
		}

		global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0;
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/umeng/socialize/UMAuthListenerImplementor")]
	internal sealed partial class IUMAuthListenerImplementor : global::Java.Lang.Object, IUMAuthListener {

		object sender;

		public IUMAuthListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/umeng/socialize/UMAuthListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AuthCancelEventArgs> OnAuthCancelHandler;
#pragma warning restore 0649

		public void OnAuthCancel (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1)
		{
			var __h = OnAuthCancelHandler;
			if (__h != null)
				__h (sender, new AuthCancelEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<AuthCompleteEventArgs> OnAuthCompleteHandler;
#pragma warning restore 0649

		public void OnAuthComplete (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			var __h = OnAuthCompleteHandler;
			if (__h != null)
				__h (sender, new AuthCompleteEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<AuthErrorEventArgs> OnAuthErrorHandler;
#pragma warning restore 0649

		public void OnAuthError (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, int p1, global::Java.Lang.Throwable p2)
		{
			var __h = OnAuthErrorHandler;
			if (__h != null)
				__h (sender, new AuthErrorEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<AuthStartEventArgs> OnAuthStartHandler;
#pragma warning restore 0649

		public void OnAuthStart (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			var __h = OnAuthStartHandler;
			if (__h != null)
				__h (sender, new AuthStartEventArgs (p0));
		}

		internal static bool __IsEmpty (IUMAuthListenerImplementor value)
		{
			return value.OnAuthCancelHandler == null && value.OnAuthCompleteHandler == null && value.OnAuthErrorHandler == null && value.OnAuthStartHandler == null;
		}
	}

}
