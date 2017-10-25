using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMShareListener']"
	[Register ("com/umeng/socialize/UMShareListener", "", "Com.Umeng.Socialize.IUMShareListenerInvoker")]
	public partial interface IUMShareListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMShareListener']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("onCancel", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", "GetOnCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng")]
		void OnCancel (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMShareListener']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onError", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/Throwable;)V", "GetOnError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng")]
		void OnError (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMShareListener']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("onResult", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", "GetOnResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng")]
		void OnResult (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/interface[@name='UMShareListener']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("onStart", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", "GetOnStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.IUMShareListenerInvoker, UMeng")]
		void OnStart (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0);

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/UMShareListener", DoNotGenerateAcw=true)]
	internal class IUMShareListenerInvoker : global::Java.Lang.Object, IUMShareListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/UMShareListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUMShareListenerInvoker); }
		}

		IntPtr class_ref;

		public static IUMShareListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUMShareListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.UMShareListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUMShareListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetOnCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static void n_OnCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.IUMShareListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		public unsafe void OnCancel (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "onCancel", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
		}

		static Delegate cb_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_ == null)
				cb_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_);
			return cb_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_;
		}

		static void n_OnError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.IUMShareListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_;
		public unsafe void OnError (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, global::Java.Lang.Throwable p1)
		{
			if (id_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_umeng_socialize_bean_SHARE_MEDIA_Ljava_lang_Throwable_, __args);
		}

		static Delegate cb_onResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetOnResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_onResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_onResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_onResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static void n_OnResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.IUMShareListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		public unsafe void OnResult (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_onResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_onResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
		}

		static Delegate cb_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetOnStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static void n_OnStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.IUMShareListener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStart (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		public unsafe void OnStart (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "onStart", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
		}

	}

	public partial class CancelEventArgs : global::System.EventArgs {

		public CancelEventArgs (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			this.p0 = p0;
		}

		global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0;
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA P0 {
			get { return p0; }
		}
	}

	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, global::Java.Lang.Throwable p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0;
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA P0 {
			get { return p0; }
		}

		global::Java.Lang.Throwable p1;
		public global::Java.Lang.Throwable P1 {
			get { return p1; }
		}
	}

	public partial class ResultEventArgs : global::System.EventArgs {

		public ResultEventArgs (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			this.p0 = p0;
		}

		global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0;
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA P0 {
			get { return p0; }
		}
	}

	public partial class StartEventArgs : global::System.EventArgs {

		public StartEventArgs (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			this.p0 = p0;
		}

		global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0;
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/umeng/socialize/UMShareListenerImplementor")]
	internal sealed partial class IUMShareListenerImplementor : global::Java.Lang.Object, IUMShareListener {

		object sender;

		public IUMShareListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/umeng/socialize/UMShareListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CancelEventArgs> OnCancelHandler;
#pragma warning restore 0649

		public void OnCancel (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			var __h = OnCancelHandler;
			if (__h != null)
				__h (sender, new CancelEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0, global::Java.Lang.Throwable p1)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ResultEventArgs> OnResultHandler;
#pragma warning restore 0649

		public void OnResult (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			var __h = OnResultHandler;
			if (__h != null)
				__h (sender, new ResultEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<StartEventArgs> OnStartHandler;
#pragma warning restore 0649

		public void OnStart (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			var __h = OnStartHandler;
			if (__h != null)
				__h (sender, new StartEventArgs (p0));
		}

		internal static bool __IsEmpty (IUMShareListenerImplementor value)
		{
			return value.OnCancelHandler == null && value.OnErrorHandler == null && value.OnResultHandler == null && value.OnStartHandler == null;
		}
	}

}
