using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='IWeiboHandler.Request']"
	[Register ("com/umeng/socialize/media/IWeiboHandler$Request", "", "Com.Umeng.Socialize.Media.IWeiboHandlerRequestInvoker")]
	public partial interface IWeiboHandlerRequest : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='IWeiboHandler.Request']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.sina.message.BaseRequest']]"
		[Register ("a", "(Lcom/umeng/socialize/sina/message/BaseRequest;)V", "GetA_Lcom_umeng_socialize_sina_message_BaseRequest_Handler:Com.Umeng.Socialize.Media.IWeiboHandlerRequestInvoker, UMeng")]
		void A (global::Com.Umeng.Socialize.Sina.Message.BaseRequest p0);

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/media/IWeiboHandler$Request", DoNotGenerateAcw=true)]
	internal class IWeiboHandlerRequestInvoker : global::Java.Lang.Object, IWeiboHandlerRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/media/IWeiboHandler$Request");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWeiboHandlerRequestInvoker); }
		}

		IntPtr class_ref;

		public static IWeiboHandlerRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWeiboHandlerRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.media.IWeiboHandler.Request"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWeiboHandlerRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_a_Lcom_umeng_socialize_sina_message_BaseRequest_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_umeng_socialize_sina_message_BaseRequest_Handler ()
		{
			if (cb_a_Lcom_umeng_socialize_sina_message_BaseRequest_ == null)
				cb_a_Lcom_umeng_socialize_sina_message_BaseRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_umeng_socialize_sina_message_BaseRequest_);
			return cb_a_Lcom_umeng_socialize_sina_message_BaseRequest_;
		}

		static void n_A_Lcom_umeng_socialize_sina_message_BaseRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.IWeiboHandlerRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IWeiboHandlerRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Sina.Message.BaseRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Message.BaseRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_umeng_socialize_sina_message_BaseRequest_;
		public unsafe void A (global::Com.Umeng.Socialize.Sina.Message.BaseRequest p0)
		{
			if (id_a_Lcom_umeng_socialize_sina_message_BaseRequest_ == IntPtr.Zero)
				id_a_Lcom_umeng_socialize_sina_message_BaseRequest_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/umeng/socialize/sina/message/BaseRequest;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_umeng_socialize_sina_message_BaseRequest_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='IWeiboHandler.Response']"
	[Register ("com/umeng/socialize/media/IWeiboHandler$Response", "", "Com.Umeng.Socialize.Media.IWeiboHandlerResponseInvoker")]
	public partial interface IWeiboHandlerResponse : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='IWeiboHandler.Response']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.sina.message.BaseResponse']]"
		[Register ("a", "(Lcom/umeng/socialize/sina/message/BaseResponse;)V", "GetA_Lcom_umeng_socialize_sina_message_BaseResponse_Handler:Com.Umeng.Socialize.Media.IWeiboHandlerResponseInvoker, UMeng")]
		void A (global::Com.Umeng.Socialize.Sina.Message.BaseResponse p0);

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/media/IWeiboHandler$Response", DoNotGenerateAcw=true)]
	internal class IWeiboHandlerResponseInvoker : global::Java.Lang.Object, IWeiboHandlerResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/media/IWeiboHandler$Response");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWeiboHandlerResponseInvoker); }
		}

		IntPtr class_ref;

		public static IWeiboHandlerResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWeiboHandlerResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.media.IWeiboHandler.Response"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWeiboHandlerResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_a_Lcom_umeng_socialize_sina_message_BaseResponse_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_umeng_socialize_sina_message_BaseResponse_Handler ()
		{
			if (cb_a_Lcom_umeng_socialize_sina_message_BaseResponse_ == null)
				cb_a_Lcom_umeng_socialize_sina_message_BaseResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_umeng_socialize_sina_message_BaseResponse_);
			return cb_a_Lcom_umeng_socialize_sina_message_BaseResponse_;
		}

		static void n_A_Lcom_umeng_socialize_sina_message_BaseResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.IWeiboHandlerResponse __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IWeiboHandlerResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Sina.Message.BaseResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Message.BaseResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		IntPtr id_a_Lcom_umeng_socialize_sina_message_BaseResponse_;
		public unsafe void A (global::Com.Umeng.Socialize.Sina.Message.BaseResponse p0)
		{
			if (id_a_Lcom_umeng_socialize_sina_message_BaseResponse_ == IntPtr.Zero)
				id_a_Lcom_umeng_socialize_sina_message_BaseResponse_ = JNIEnv.GetMethodID (class_ref, "a", "(Lcom/umeng/socialize/sina/message/BaseResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Lcom_umeng_socialize_sina_message_BaseResponse_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='IWeiboHandler']"
	[Register ("com/umeng/socialize/media/IWeiboHandler", "", "Com.Umeng.Socialize.Media.IWeiboHandlerInvoker")]
	public partial interface IWeiboHandler : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/media/IWeiboHandler", DoNotGenerateAcw=true)]
	internal class IWeiboHandlerInvoker : global::Java.Lang.Object, IWeiboHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/media/IWeiboHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWeiboHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IWeiboHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWeiboHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.media.IWeiboHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWeiboHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
