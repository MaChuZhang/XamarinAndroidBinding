using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/SimpleShareContent", DoNotGenerateAcw=true)]
	public partial class SimpleShareContent : global::Java.Lang.Object {


		static IntPtr DEFAULT_DESCRIPTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/field[@name='DEFAULT_DESCRIPTION']"
		[Register ("DEFAULT_DESCRIPTION")]
		public string DefaultDescription {
			get {
				if (DEFAULT_DESCRIPTION_jfieldId == IntPtr.Zero)
					DEFAULT_DESCRIPTION_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT_DESCRIPTION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DEFAULT_DESCRIPTION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_DESCRIPTION_jfieldId == IntPtr.Zero)
					DEFAULT_DESCRIPTION_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT_DESCRIPTION", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DEFAULT_DESCRIPTION_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DEFAULT_TITLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/field[@name='DEFAULT_TITLE']"
		[Register ("DEFAULT_TITLE")]
		public string DefaultTitle {
			get {
				if (DEFAULT_TITLE_jfieldId == IntPtr.Zero)
					DEFAULT_TITLE_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT_TITLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DEFAULT_TITLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_TITLE_jfieldId == IntPtr.Zero)
					DEFAULT_TITLE_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT_TITLE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DEFAULT_TITLE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr IMAGE_LIMIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/field[@name='IMAGE_LIMIT']"
		[Register ("IMAGE_LIMIT")]
		public int ImageLimit {
			get {
				if (IMAGE_LIMIT_jfieldId == IntPtr.Zero)
					IMAGE_LIMIT_jfieldId = JNIEnv.GetFieldID (class_ref, "IMAGE_LIMIT", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, IMAGE_LIMIT_jfieldId);
			}
			set {
				if (IMAGE_LIMIT_jfieldId == IntPtr.Zero)
					IMAGE_LIMIT_jfieldId = JNIEnv.GetFieldID (class_ref, "IMAGE_LIMIT", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, IMAGE_LIMIT_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr THUMB_LIMIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/field[@name='THUMB_LIMIT']"
		[Register ("THUMB_LIMIT")]
		public int ThumbLimit {
			get {
				if (THUMB_LIMIT_jfieldId == IntPtr.Zero)
					THUMB_LIMIT_jfieldId = JNIEnv.GetFieldID (class_ref, "THUMB_LIMIT", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, THUMB_LIMIT_jfieldId);
			}
			set {
				if (THUMB_LIMIT_jfieldId == IntPtr.Zero)
					THUMB_LIMIT_jfieldId = JNIEnv.GetFieldID (class_ref, "THUMB_LIMIT", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, THUMB_LIMIT_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr WX_THUMB_LIMIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/field[@name='WX_THUMB_LIMIT']"
		[Register ("WX_THUMB_LIMIT")]
		public int WxThumbLimit {
			get {
				if (WX_THUMB_LIMIT_jfieldId == IntPtr.Zero)
					WX_THUMB_LIMIT_jfieldId = JNIEnv.GetFieldID (class_ref, "WX_THUMB_LIMIT", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, WX_THUMB_LIMIT_jfieldId);
			}
			set {
				if (WX_THUMB_LIMIT_jfieldId == IntPtr.Zero)
					WX_THUMB_LIMIT_jfieldId = JNIEnv.GetFieldID (class_ref, "WX_THUMB_LIMIT", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, WX_THUMB_LIMIT_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/SimpleShareContent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleShareContent); }
		}

		protected SimpleShareContent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_umeng_socialize_ShareContent_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/constructor[@name='SimpleShareContent' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.ShareContent']]"
		[Register (".ctor", "(Lcom/umeng/socialize/ShareContent;)V", "")]
		public unsafe SimpleShareContent (global::Com.Umeng.Socialize.ShareContent p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SimpleShareContent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/umeng/socialize/ShareContent;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/umeng/socialize/ShareContent;)V", __args);
					return;
				}

				if (id_ctor_Lcom_umeng_socialize_ShareContent_ == IntPtr.Zero)
					id_ctor_Lcom_umeng_socialize_ShareContent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/ShareContent;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_ShareContent_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_ShareContent_, __args);
			} finally {
			}
		}

		static Delegate cb_getAssertSubject;
#pragma warning disable 0169
		static Delegate GetGetAssertSubjectHandler ()
		{
			if (cb_getAssertSubject == null)
				cb_getAssertSubject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAssertSubject);
			return cb_getAssertSubject;
		}

		static IntPtr n_GetAssertSubject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AssertSubject);
		}
#pragma warning restore 0169

		static IntPtr id_getAssertSubject;
		public virtual unsafe string AssertSubject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getAssertSubject' and count(parameter)=0]"
			[Register ("getAssertSubject", "()Ljava/lang/String;", "GetGetAssertSubjectHandler")]
			get {
				if (id_getAssertSubject == IntPtr.Zero)
					id_getAssertSubject = JNIEnv.GetMethodID (class_ref, "getAssertSubject", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAssertSubject), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAssertSubject", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBaseMediaObject;
#pragma warning disable 0169
		static Delegate GetGetBaseMediaObjectHandler ()
		{
			if (cb_getBaseMediaObject == null)
				cb_getBaseMediaObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseMediaObject);
			return cb_getBaseMediaObject;
		}

		static IntPtr n_GetBaseMediaObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseMediaObject);
		}
#pragma warning restore 0169

		static IntPtr id_getBaseMediaObject;
		public virtual unsafe global::Com.Umeng.Socialize.Media.BaseMediaObject BaseMediaObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getBaseMediaObject' and count(parameter)=0]"
			[Register ("getBaseMediaObject", "()Lcom/umeng/socialize/media/BaseMediaObject;", "GetGetBaseMediaObjectHandler")]
			get {
				if (id_getBaseMediaObject == IntPtr.Zero)
					id_getBaseMediaObject = JNIEnv.GetMethodID (class_ref, "getBaseMediaObject", "()Lcom/umeng/socialize/media/BaseMediaObject;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseMediaObject), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaseMediaObject", "()Lcom/umeng/socialize/media/BaseMediaObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFile;
#pragma warning disable 0169
		static Delegate GetGetFileHandler ()
		{
			if (cb_getFile == null)
				cb_getFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFile);
			return cb_getFile;
		}

		static IntPtr n_GetFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.File);
		}
#pragma warning restore 0169

		static IntPtr id_getFile;
		public virtual unsafe global::Java.IO.File File {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getFile' and count(parameter)=0]"
			[Register ("getFile", "()Ljava/io/File;", "GetGetFileHandler")]
			get {
				if (id_getFile == IntPtr.Zero)
					id_getFile = JNIEnv.GetMethodID (class_ref, "getFile", "()Ljava/io/File;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFile), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFile", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static Delegate cb_setImage_Lcom_umeng_socialize_media_UMImage_;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_umeng_socialize_media_UMImage_Handler ()
		{
			if (cb_setImage_Lcom_umeng_socialize_media_UMImage_ == null)
				cb_setImage_Lcom_umeng_socialize_media_UMImage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Lcom_umeng_socialize_media_UMImage_);
			return cb_setImage_Lcom_umeng_socialize_media_UMImage_;
		}

		static void n_SetImage_Lcom_umeng_socialize_media_UMImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMImage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Image = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		static IntPtr id_setImage_Lcom_umeng_socialize_media_UMImage_;
		public virtual unsafe global::Com.Umeng.Socialize.Media.UMImage Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Lcom/umeng/socialize/media/UMImage;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Lcom/umeng/socialize/media/UMImage;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Lcom/umeng/socialize/media/UMImage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMImage']]"
			[Register ("setImage", "(Lcom/umeng/socialize/media/UMImage;)V", "GetSetImage_Lcom_umeng_socialize_media_UMImage_Handler")]
			set {
				if (id_setImage_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
					id_setImage_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/umeng/socialize/media/UMImage;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lcom_umeng_socialize_media_UMImage_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Lcom/umeng/socialize/media/UMImage;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMusic;
#pragma warning disable 0169
		static Delegate GetGetMusicHandler ()
		{
			if (cb_getMusic == null)
				cb_getMusic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMusic);
			return cb_getMusic;
		}

		static IntPtr n_GetMusic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Music);
		}
#pragma warning restore 0169

		static Delegate cb_setMusic_Lcom_umeng_socialize_media_UMusic_;
#pragma warning disable 0169
		static Delegate GetSetMusic_Lcom_umeng_socialize_media_UMusic_Handler ()
		{
			if (cb_setMusic_Lcom_umeng_socialize_media_UMusic_ == null)
				cb_setMusic_Lcom_umeng_socialize_media_UMusic_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMusic_Lcom_umeng_socialize_media_UMusic_);
			return cb_setMusic_Lcom_umeng_socialize_media_UMusic_;
		}

		static void n_SetMusic_Lcom_umeng_socialize_media_UMusic_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMusic p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Music = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMusic;
		static IntPtr id_setMusic_Lcom_umeng_socialize_media_UMusic_;
		public virtual unsafe global::Com.Umeng.Socialize.Media.UMusic Music {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getMusic' and count(parameter)=0]"
			[Register ("getMusic", "()Lcom/umeng/socialize/media/UMusic;", "GetGetMusicHandler")]
			get {
				if (id_getMusic == IntPtr.Zero)
					id_getMusic = JNIEnv.GetMethodID (class_ref, "getMusic", "()Lcom/umeng/socialize/media/UMusic;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMusic), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMusic", "()Lcom/umeng/socialize/media/UMusic;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='setMusic' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMusic']]"
			[Register ("setMusic", "(Lcom/umeng/socialize/media/UMusic;)V", "GetSetMusic_Lcom_umeng_socialize_media_UMusic_Handler")]
			set {
				if (id_setMusic_Lcom_umeng_socialize_media_UMusic_ == IntPtr.Zero)
					id_setMusic_Lcom_umeng_socialize_media_UMusic_ = JNIEnv.GetMethodID (class_ref, "setMusic", "(Lcom/umeng/socialize/media/UMusic;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMusic_Lcom_umeng_socialize_media_UMusic_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMusic", "(Lcom/umeng/socialize/media/UMusic;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStrStyle;
#pragma warning disable 0169
		static Delegate GetGetStrStyleHandler ()
		{
			if (cb_getStrStyle == null)
				cb_getStrStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStrStyle);
			return cb_getStrStyle;
		}

		static IntPtr n_GetStrStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StrStyle);
		}
#pragma warning restore 0169

		static IntPtr id_getStrStyle;
		public virtual unsafe string StrStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getStrStyle' and count(parameter)=0]"
			[Register ("getStrStyle", "()Ljava/lang/String;", "GetGetStrStyleHandler")]
			get {
				if (id_getStrStyle == IntPtr.Zero)
					id_getStrStyle = JNIEnv.GetMethodID (class_ref, "getStrStyle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStrStyle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrStyle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubject;
#pragma warning disable 0169
		static Delegate GetGetSubjectHandler ()
		{
			if (cb_getSubject == null)
				cb_getSubject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubject);
			return cb_getSubject;
		}

		static IntPtr n_GetSubject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Subject);
		}
#pragma warning restore 0169

		static IntPtr id_getSubject;
		public virtual unsafe string Subject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getSubject' and count(parameter)=0]"
			[Register ("getSubject", "()Ljava/lang/String;", "GetGetSubjectHandler")]
			get {
				if (id_getSubject == IntPtr.Zero)
					id_getSubject = JNIEnv.GetMethodID (class_ref, "getSubject", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubject), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubject", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static Delegate cb_setText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_String_Handler ()
		{
			if (cb_setText_Ljava_lang_String_ == null)
				cb_setText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
			return cb_setText_Ljava_lang_String_;
		}

		static void n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Text = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getText;
		static IntPtr id_setText_Ljava_lang_String_;
		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
			set {
				if (id_setText_Ljava_lang_String_ == IntPtr.Zero)
					id_setText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUmEmoji;
#pragma warning disable 0169
		static Delegate GetGetUmEmojiHandler ()
		{
			if (cb_getUmEmoji == null)
				cb_getUmEmoji = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUmEmoji);
			return cb_getUmEmoji;
		}

		static IntPtr n_GetUmEmoji (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UmEmoji);
		}
#pragma warning restore 0169

		static IntPtr id_getUmEmoji;
		public virtual unsafe global::Com.Umeng.Socialize.Media.UMEmoji UmEmoji {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getUmEmoji' and count(parameter)=0]"
			[Register ("getUmEmoji", "()Lcom/umeng/socialize/media/UMEmoji;", "GetGetUmEmojiHandler")]
			get {
				if (id_getUmEmoji == IntPtr.Zero)
					id_getUmEmoji = JNIEnv.GetMethodID (class_ref, "getUmEmoji", "()Lcom/umeng/socialize/media/UMEmoji;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMEmoji> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUmEmoji), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMEmoji> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUmEmoji", "()Lcom/umeng/socialize/media/UMEmoji;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUmMin;
#pragma warning disable 0169
		static Delegate GetGetUmMinHandler ()
		{
			if (cb_getUmMin == null)
				cb_getUmMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUmMin);
			return cb_getUmMin;
		}

		static IntPtr n_GetUmMin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UmMin);
		}
#pragma warning restore 0169

		static IntPtr id_getUmMin;
		public virtual unsafe global::Com.Umeng.Socialize.Media.UMMin UmMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getUmMin' and count(parameter)=0]"
			[Register ("getUmMin", "()Lcom/umeng/socialize/media/UMMin;", "GetGetUmMinHandler")]
			get {
				if (id_getUmMin == IntPtr.Zero)
					id_getUmMin = JNIEnv.GetMethodID (class_ref, "getUmMin", "()Lcom/umeng/socialize/media/UMMin;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUmMin), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUmMin", "()Lcom/umeng/socialize/media/UMMin;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUmWeb;
#pragma warning disable 0169
		static Delegate GetGetUmWebHandler ()
		{
			if (cb_getUmWeb == null)
				cb_getUmWeb = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUmWeb);
			return cb_getUmWeb;
		}

		static IntPtr n_GetUmWeb (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UmWeb);
		}
#pragma warning restore 0169

		static IntPtr id_getUmWeb;
		public virtual unsafe global::Com.Umeng.Socialize.Media.UMWeb UmWeb {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getUmWeb' and count(parameter)=0]"
			[Register ("getUmWeb", "()Lcom/umeng/socialize/media/UMWeb;", "GetGetUmWebHandler")]
			get {
				if (id_getUmWeb == IntPtr.Zero)
					id_getUmWeb = JNIEnv.GetMethodID (class_ref, "getUmWeb", "()Lcom/umeng/socialize/media/UMWeb;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMWeb> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUmWeb), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMWeb> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUmWeb", "()Lcom/umeng/socialize/media/UMWeb;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideo;
#pragma warning disable 0169
		static Delegate GetGetVideoHandler ()
		{
			if (cb_getVideo == null)
				cb_getVideo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideo);
			return cb_getVideo;
		}

		static IntPtr n_GetVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Video);
		}
#pragma warning restore 0169

		static Delegate cb_setVideo_Lcom_umeng_socialize_media_UMVideo_;
#pragma warning disable 0169
		static Delegate GetSetVideo_Lcom_umeng_socialize_media_UMVideo_Handler ()
		{
			if (cb_setVideo_Lcom_umeng_socialize_media_UMVideo_ == null)
				cb_setVideo_Lcom_umeng_socialize_media_UMVideo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideo_Lcom_umeng_socialize_media_UMVideo_);
			return cb_setVideo_Lcom_umeng_socialize_media_UMVideo_;
		}

		static void n_SetVideo_Lcom_umeng_socialize_media_UMVideo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMVideo p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMVideo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Video = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideo;
		static IntPtr id_setVideo_Lcom_umeng_socialize_media_UMVideo_;
		public virtual unsafe global::Com.Umeng.Socialize.Media.UMVideo Video {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getVideo' and count(parameter)=0]"
			[Register ("getVideo", "()Lcom/umeng/socialize/media/UMVideo;", "GetGetVideoHandler")]
			get {
				if (id_getVideo == IntPtr.Zero)
					id_getVideo = JNIEnv.GetMethodID (class_ref, "getVideo", "()Lcom/umeng/socialize/media/UMVideo;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMVideo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMVideo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideo", "()Lcom/umeng/socialize/media/UMVideo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='setVideo' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMVideo']]"
			[Register ("setVideo", "(Lcom/umeng/socialize/media/UMVideo;)V", "GetSetVideo_Lcom_umeng_socialize_media_UMVideo_Handler")]
			set {
				if (id_setVideo_Lcom_umeng_socialize_media_UMVideo_ == IntPtr.Zero)
					id_setVideo_Lcom_umeng_socialize_media_UMVideo_ = JNIEnv.GetMethodID (class_ref, "setVideo", "(Lcom/umeng/socialize/media/UMVideo;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideo_Lcom_umeng_socialize_media_UMVideo_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideo", "(Lcom/umeng/socialize/media/UMVideo;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_canFileValid_Lcom_umeng_socialize_media_UMImage_;
#pragma warning disable 0169
		static Delegate GetCanFileValid_Lcom_umeng_socialize_media_UMImage_Handler ()
		{
			if (cb_canFileValid_Lcom_umeng_socialize_media_UMImage_ == null)
				cb_canFileValid_Lcom_umeng_socialize_media_UMImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanFileValid_Lcom_umeng_socialize_media_UMImage_);
			return cb_canFileValid_Lcom_umeng_socialize_media_UMImage_;
		}

		static bool n_CanFileValid_Lcom_umeng_socialize_media_UMImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMImage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanFileValid (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_canFileValid_Lcom_umeng_socialize_media_UMImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='canFileValid' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMImage']]"
		[Register ("canFileValid", "(Lcom/umeng/socialize/media/UMImage;)Z", "GetCanFileValid_Lcom_umeng_socialize_media_UMImage_Handler")]
		public virtual unsafe bool CanFileValid (global::Com.Umeng.Socialize.Media.UMImage p0)
		{
			if (id_canFileValid_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
				id_canFileValid_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "canFileValid", "(Lcom/umeng/socialize/media/UMImage;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canFileValid_Lcom_umeng_socialize_media_UMImage_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canFileValid", "(Lcom/umeng/socialize/media/UMImage;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getImageData_Lcom_umeng_socialize_media_UMImage_;
#pragma warning disable 0169
		static Delegate GetGetImageData_Lcom_umeng_socialize_media_UMImage_Handler ()
		{
			if (cb_getImageData_Lcom_umeng_socialize_media_UMImage_ == null)
				cb_getImageData_Lcom_umeng_socialize_media_UMImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImageData_Lcom_umeng_socialize_media_UMImage_);
			return cb_getImageData_Lcom_umeng_socialize_media_UMImage_;
		}

		static IntPtr n_GetImageData_Lcom_umeng_socialize_media_UMImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMImage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetImageData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageData_Lcom_umeng_socialize_media_UMImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getImageData' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMImage']]"
		[Register ("getImageData", "(Lcom/umeng/socialize/media/UMImage;)[B", "GetGetImageData_Lcom_umeng_socialize_media_UMImage_Handler")]
		public virtual unsafe byte[] GetImageData (global::Com.Umeng.Socialize.Media.UMImage p0)
		{
			if (id_getImageData_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
				id_getImageData_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "getImageData", "(Lcom/umeng/socialize/media/UMImage;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageData_Lcom_umeng_socialize_media_UMImage_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageData", "(Lcom/umeng/socialize/media/UMImage;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getImageThumb_Lcom_umeng_socialize_media_UMImage_;
#pragma warning disable 0169
		static Delegate GetGetImageThumb_Lcom_umeng_socialize_media_UMImage_Handler ()
		{
			if (cb_getImageThumb_Lcom_umeng_socialize_media_UMImage_ == null)
				cb_getImageThumb_Lcom_umeng_socialize_media_UMImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImageThumb_Lcom_umeng_socialize_media_UMImage_);
			return cb_getImageThumb_Lcom_umeng_socialize_media_UMImage_;
		}

		static IntPtr n_GetImageThumb_Lcom_umeng_socialize_media_UMImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMImage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetImageThumb (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageThumb_Lcom_umeng_socialize_media_UMImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getImageThumb' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMImage']]"
		[Register ("getImageThumb", "(Lcom/umeng/socialize/media/UMImage;)[B", "GetGetImageThumb_Lcom_umeng_socialize_media_UMImage_Handler")]
		public virtual unsafe byte[] GetImageThumb (global::Com.Umeng.Socialize.Media.UMImage p0)
		{
			if (id_getImageThumb_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
				id_getImageThumb_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "getImageThumb", "(Lcom/umeng/socialize/media/UMImage;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageThumb_Lcom_umeng_socialize_media_UMImage_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageThumb", "(Lcom/umeng/socialize/media/UMImage;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_;
#pragma warning disable 0169
		static Delegate GetGetMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_Handler ()
		{
			if (cb_getMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_ == null)
				cb_getMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_);
			return cb_getMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_;
		}

		static IntPtr n_GetMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMusic p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMusicTargetUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getMusicTargetUrl' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMusic']]"
		[Register ("getMusicTargetUrl", "(Lcom/umeng/socialize/media/UMusic;)Ljava/lang/String;", "GetGetMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_Handler")]
		public virtual unsafe string GetMusicTargetUrl (global::Com.Umeng.Socialize.Media.UMusic p0)
		{
			if (id_getMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_ == IntPtr.Zero)
				id_getMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_ = JNIEnv.GetMethodID (class_ref, "getMusicTargetUrl", "(Lcom/umeng/socialize/media/UMusic;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMusicTargetUrl_Lcom_umeng_socialize_media_UMusic_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMusicTargetUrl", "(Lcom/umeng/socialize/media/UMusic;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getStrictImageData_Lcom_umeng_socialize_media_UMImage_;
#pragma warning disable 0169
		static Delegate GetGetStrictImageData_Lcom_umeng_socialize_media_UMImage_Handler ()
		{
			if (cb_getStrictImageData_Lcom_umeng_socialize_media_UMImage_ == null)
				cb_getStrictImageData_Lcom_umeng_socialize_media_UMImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStrictImageData_Lcom_umeng_socialize_media_UMImage_);
			return cb_getStrictImageData_Lcom_umeng_socialize_media_UMImage_;
		}

		static IntPtr n_GetStrictImageData_Lcom_umeng_socialize_media_UMImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMImage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetStrictImageData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStrictImageData_Lcom_umeng_socialize_media_UMImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getStrictImageData' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMImage']]"
		[Register ("getStrictImageData", "(Lcom/umeng/socialize/media/UMImage;)[B", "GetGetStrictImageData_Lcom_umeng_socialize_media_UMImage_Handler")]
		public virtual unsafe byte[] GetStrictImageData (global::Com.Umeng.Socialize.Media.UMImage p0)
		{
			if (id_getStrictImageData_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
				id_getStrictImageData_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "getStrictImageData", "(Lcom/umeng/socialize/media/UMImage;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStrictImageData_Lcom_umeng_socialize_media_UMImage_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrictImageData", "(Lcom/umeng/socialize/media/UMImage;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getUMImageScale_Lcom_umeng_socialize_media_UMImage_;
#pragma warning disable 0169
		static Delegate GetGetUMImageScale_Lcom_umeng_socialize_media_UMImage_Handler ()
		{
			if (cb_getUMImageScale_Lcom_umeng_socialize_media_UMImage_ == null)
				cb_getUMImageScale_Lcom_umeng_socialize_media_UMImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetUMImageScale_Lcom_umeng_socialize_media_UMImage_);
			return cb_getUMImageScale_Lcom_umeng_socialize_media_UMImage_;
		}

		static int n_GetUMImageScale_Lcom_umeng_socialize_media_UMImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMImage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUMImageScale (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUMImageScale_Lcom_umeng_socialize_media_UMImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getUMImageScale' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMImage']]"
		[Register ("getUMImageScale", "(Lcom/umeng/socialize/media/UMImage;)I", "GetGetUMImageScale_Lcom_umeng_socialize_media_UMImage_Handler")]
		public virtual unsafe int GetUMImageScale (global::Com.Umeng.Socialize.Media.UMImage p0)
		{
			if (id_getUMImageScale_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
				id_getUMImageScale_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "getUMImageScale", "(Lcom/umeng/socialize/media/UMImage;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUMImageScale_Lcom_umeng_socialize_media_UMImage_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUMImageScale", "(Lcom/umeng/socialize/media/UMImage;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getmStyle;
#pragma warning disable 0169
		static Delegate GetGetmStyleHandler ()
		{
			if (cb_getmStyle == null)
				cb_getmStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetmStyle);
			return cb_getmStyle;
		}

		static int n_GetmStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetmStyle ();
		}
#pragma warning restore 0169

		static IntPtr id_getmStyle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='getmStyle' and count(parameter)=0]"
		[Register ("getmStyle", "()I", "GetGetmStyleHandler")]
		public virtual unsafe int GetmStyle ()
		{
			if (id_getmStyle == IntPtr.Zero)
				id_getmStyle = JNIEnv.GetMethodID (class_ref, "getmStyle", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getmStyle);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmStyle", "()I"));
			} finally {
			}
		}

		static Delegate cb_objectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_;
#pragma warning disable 0169
		static Delegate GetObjectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_Handler ()
		{
			if (cb_objectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_ == null)
				cb_objectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ObjectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_);
			return cb_objectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_;
		}

		static IntPtr n_ObjectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.BaseMediaObject p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ObjectSetDescription (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_objectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='objectSetDescription' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.BaseMediaObject']]"
		[Register ("objectSetDescription", "(Lcom/umeng/socialize/media/BaseMediaObject;)Ljava/lang/String;", "GetObjectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_Handler")]
		public virtual unsafe string ObjectSetDescription (global::Com.Umeng.Socialize.Media.BaseMediaObject p0)
		{
			if (id_objectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_ == IntPtr.Zero)
				id_objectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_ = JNIEnv.GetMethodID (class_ref, "objectSetDescription", "(Lcom/umeng/socialize/media/BaseMediaObject;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_objectSetDescription_Lcom_umeng_socialize_media_BaseMediaObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "objectSetDescription", "(Lcom/umeng/socialize/media/BaseMediaObject;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_objectSetText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetObjectSetText_Ljava_lang_String_Handler ()
		{
			if (cb_objectSetText_Ljava_lang_String_ == null)
				cb_objectSetText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ObjectSetText_Ljava_lang_String_);
			return cb_objectSetText_Ljava_lang_String_;
		}

		static IntPtr n_ObjectSetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ObjectSetText (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_objectSetText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='objectSetText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("objectSetText", "(Ljava/lang/String;)Ljava/lang/String;", "GetObjectSetText_Ljava_lang_String_Handler")]
		public virtual unsafe string ObjectSetText (string p0)
		{
			if (id_objectSetText_Ljava_lang_String_ == IntPtr.Zero)
				id_objectSetText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "objectSetText", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_objectSetText_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "objectSetText", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_objectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_;
#pragma warning disable 0169
		static Delegate GetObjectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_Handler ()
		{
			if (cb_objectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_ == null)
				cb_objectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ObjectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_);
			return cb_objectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_;
		}

		static IntPtr n_ObjectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.BaseMediaObject p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ObjectSetThumb (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_objectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='objectSetThumb' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.BaseMediaObject']]"
		[Register ("objectSetThumb", "(Lcom/umeng/socialize/media/BaseMediaObject;)[B", "GetObjectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_Handler")]
		public virtual unsafe byte[] ObjectSetThumb (global::Com.Umeng.Socialize.Media.BaseMediaObject p0)
		{
			if (id_objectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_ == IntPtr.Zero)
				id_objectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_ = JNIEnv.GetMethodID (class_ref, "objectSetThumb", "(Lcom/umeng/socialize/media/BaseMediaObject;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_objectSetThumb_Lcom_umeng_socialize_media_BaseMediaObject_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "objectSetThumb", "(Lcom/umeng/socialize/media/BaseMediaObject;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_objectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_;
#pragma warning disable 0169
		static Delegate GetObjectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_Handler ()
		{
			if (cb_objectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_ == null)
				cb_objectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ObjectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_);
			return cb_objectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_;
		}

		static IntPtr n_ObjectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.BaseMediaObject p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ObjectSetTitle (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_objectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='objectSetTitle' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.BaseMediaObject']]"
		[Register ("objectSetTitle", "(Lcom/umeng/socialize/media/BaseMediaObject;)Ljava/lang/String;", "GetObjectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_Handler")]
		public virtual unsafe string ObjectSetTitle (global::Com.Umeng.Socialize.Media.BaseMediaObject p0)
		{
			if (id_objectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_ == IntPtr.Zero)
				id_objectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_ = JNIEnv.GetMethodID (class_ref, "objectSetTitle", "(Lcom/umeng/socialize/media/BaseMediaObject;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_objectSetTitle_Lcom_umeng_socialize_media_BaseMediaObject_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "objectSetTitle", "(Lcom/umeng/socialize/media/BaseMediaObject;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_subString_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSubString_Ljava_lang_String_IHandler ()
		{
			if (cb_subString_Ljava_lang_String_I == null)
				cb_subString_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SubString_Ljava_lang_String_I);
			return cb_subString_Ljava_lang_String_I;
		}

		static IntPtr n_SubString_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Socialize.Media.SimpleShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SimpleShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SubString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subString_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SimpleShareContent']/method[@name='subString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("subString", "(Ljava/lang/String;I)Ljava/lang/String;", "GetSubString_Ljava_lang_String_IHandler")]
		public virtual unsafe string SubString (string p0, int p1)
		{
			if (id_subString_Ljava_lang_String_I == IntPtr.Zero)
				id_subString_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "subString", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subString_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subString", "(Ljava/lang/String;I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
