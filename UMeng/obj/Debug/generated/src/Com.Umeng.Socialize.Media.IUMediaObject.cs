using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.1']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/UMediaObject$1", DoNotGenerateAcw=true)]
	public partial class UMediaObject1 : global::Java.Lang.Object {

		protected UMediaObject1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.MediaType']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/UMediaObject$MediaType", DoNotGenerateAcw=true)]
	public partial class UMediaObjectMediaType : global::Java.Lang.Enum {


		static IntPtr IMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.MediaType']/field[@name='IMAGE']"
		[Register ("IMAGE")]
		public static global::Com.Umeng.Socialize.Media.UMediaObjectMediaType Image {
			get {
				if (IMAGE_jfieldId == IntPtr.Zero)
					IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGE", "Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MUSIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.MediaType']/field[@name='MUSIC']"
		[Register ("MUSIC")]
		public static global::Com.Umeng.Socialize.Media.UMediaObjectMediaType Music {
			get {
				if (MUSIC_jfieldId == IntPtr.Zero)
					MUSIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MUSIC", "Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MUSIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.MediaType']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Com.Umeng.Socialize.Media.UMediaObjectMediaType Text {
			get {
				if (TEXT_jfieldId == IntPtr.Zero)
					TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_IMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.MediaType']/field[@name='TEXT_IMAGE']"
		[Register ("TEXT_IMAGE")]
		public static global::Com.Umeng.Socialize.Media.UMediaObjectMediaType TextImage {
			get {
				if (TEXT_IMAGE_jfieldId == IntPtr.Zero)
					TEXT_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_IMAGE", "Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_IMAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VEDIO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.MediaType']/field[@name='VEDIO']"
		[Register ("VEDIO")]
		public static global::Com.Umeng.Socialize.Media.UMediaObjectMediaType Vedio {
			get {
				if (VEDIO_jfieldId == IntPtr.Zero)
					VEDIO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VEDIO", "Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VEDIO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WEBPAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.MediaType']/field[@name='WEBPAGE']"
		[Register ("WEBPAGE")]
		public static global::Com.Umeng.Socialize.Media.UMediaObjectMediaType Webpage {
			get {
				if (WEBPAGE_jfieldId == IntPtr.Zero)
					WEBPAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEBPAGE", "Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEBPAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/UMediaObject$MediaType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMediaObjectMediaType); }
		}

		protected UMediaObjectMediaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.MediaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/media/UMediaObject$MediaType;", "")]
		public static unsafe global::Com.Umeng.Socialize.Media.UMediaObjectMediaType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/media/UMediaObject$MediaType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Umeng.Socialize.Media.UMediaObjectMediaType __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='UMediaObject.MediaType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/umeng/socialize/media/UMediaObject$MediaType;", "")]
		public static unsafe global::Com.Umeng.Socialize.Media.UMediaObjectMediaType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/media/UMediaObject$MediaType;");
			try {
				return (global::Com.Umeng.Socialize.Media.UMediaObjectMediaType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Media.UMediaObjectMediaType));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']"
	[Register ("com/umeng/socialize/media/UMediaObject", "", "Com.Umeng.Socialize.Media.IUMediaObjectInvoker")]
	public partial interface IUMediaObject : IJavaObject {

		bool IsUrlMedia {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']/method[@name='isUrlMedia' and count(parameter)=0]"
			[Register ("isUrlMedia", "()Z", "GetIsUrlMediaHandler:Com.Umeng.Socialize.Media.IUMediaObjectInvoker, UMeng")] get;
		}

		global::Com.Umeng.Socialize.Media.UMediaObjectMediaType MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;", "GetGetMediaTypeHandler:Com.Umeng.Socialize.Media.IUMediaObjectInvoker, UMeng")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']/method[@name='toByte' and count(parameter)=0]"
		[Register ("toByte", "()[B", "GetToByteHandler:Com.Umeng.Socialize.Media.IUMediaObjectInvoker, UMeng")]
		byte[] ToByte ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']/method[@name='toUrl' and count(parameter)=0]"
		[Register ("toUrl", "()Ljava/lang/String;", "GetToUrlHandler:Com.Umeng.Socialize.Media.IUMediaObjectInvoker, UMeng")]
		string ToUrl ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/interface[@name='UMediaObject']/method[@name='toUrlExtraParams' and count(parameter)=0]"
		[Register ("toUrlExtraParams", "()Ljava/util/Map;", "GetToUrlExtraParamsHandler:Com.Umeng.Socialize.Media.IUMediaObjectInvoker, UMeng")]
		global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToUrlExtraParams ();

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/media/UMediaObject", DoNotGenerateAcw=true)]
	internal class IUMediaObjectInvoker : global::Java.Lang.Object, IUMediaObject {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/media/UMediaObject");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUMediaObjectInvoker); }
		}

		IntPtr class_ref;

		public static IUMediaObject GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUMediaObject> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.media.UMediaObject"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUMediaObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isUrlMedia;
#pragma warning disable 0169
		static Delegate GetIsUrlMediaHandler ()
		{
			if (cb_isUrlMedia == null)
				cb_isUrlMedia = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUrlMedia);
			return cb_isUrlMedia;
		}

		static bool n_IsUrlMedia (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.IUMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IUMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUrlMedia;
		}
#pragma warning restore 0169

		IntPtr id_isUrlMedia;
		public unsafe bool IsUrlMedia {
			get {
				if (id_isUrlMedia == IntPtr.Zero)
					id_isUrlMedia = JNIEnv.GetMethodID (class_ref, "isUrlMedia", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUrlMedia);
			}
		}

		static Delegate cb_getMediaType;
#pragma warning disable 0169
		static Delegate GetGetMediaTypeHandler ()
		{
			if (cb_getMediaType == null)
				cb_getMediaType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaType);
			return cb_getMediaType;
		}

		static IntPtr n_GetMediaType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.IUMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IUMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaType);
		}
#pragma warning restore 0169

		IntPtr id_getMediaType;
		public unsafe global::Com.Umeng.Socialize.Media.UMediaObjectMediaType MediaType {
			get {
				if (id_getMediaType == IntPtr.Zero)
					id_getMediaType = JNIEnv.GetMethodID (class_ref, "getMediaType", "()Lcom/umeng/socialize/media/UMediaObject$MediaType;");
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMediaObjectMediaType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_toByte;
#pragma warning disable 0169
		static Delegate GetToByteHandler ()
		{
			if (cb_toByte == null)
				cb_toByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToByte);
			return cb_toByte;
		}

		static IntPtr n_ToByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.IUMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IUMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToByte ());
		}
#pragma warning restore 0169

		IntPtr id_toByte;
		public unsafe byte[] ToByte ()
		{
			if (id_toByte == IntPtr.Zero)
				id_toByte = JNIEnv.GetMethodID (class_ref, "toByte", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toByte), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_toUrl;
#pragma warning disable 0169
		static Delegate GetToUrlHandler ()
		{
			if (cb_toUrl == null)
				cb_toUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToUrl);
			return cb_toUrl;
		}

		static IntPtr n_ToUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.IUMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IUMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToUrl ());
		}
#pragma warning restore 0169

		IntPtr id_toUrl;
		public unsafe string ToUrl ()
		{
			if (id_toUrl == IntPtr.Zero)
				id_toUrl = JNIEnv.GetMethodID (class_ref, "toUrl", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toUrl), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toUrlExtraParams;
#pragma warning disable 0169
		static Delegate GetToUrlExtraParamsHandler ()
		{
			if (cb_toUrlExtraParams == null)
				cb_toUrlExtraParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToUrlExtraParams);
			return cb_toUrlExtraParams;
		}

		static IntPtr n_ToUrlExtraParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.IUMediaObject __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IUMediaObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ToUrlExtraParams ());
		}
#pragma warning restore 0169

		IntPtr id_toUrlExtraParams;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ToUrlExtraParams ()
		{
			if (id_toUrlExtraParams == IntPtr.Zero)
				id_toUrlExtraParams = JNIEnv.GetMethodID (class_ref, "toUrlExtraParams", "()Ljava/util/Map;");
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toUrlExtraParams), JniHandleOwnership.TransferLocalRef);
		}

	}

}
