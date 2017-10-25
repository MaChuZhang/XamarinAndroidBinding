using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']"
	[global::Android.Runtime.Register ("com/umeng/socialize/ShareContent", DoNotGenerateAcw=true)]
	public partial class ShareContent : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='EMOJI_STYLE']"
		[Register ("EMOJI_STYLE")]
		public const int EmojiStyle = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='ERROR_STYLE']"
		[Register ("ERROR_STYLE")]
		public const int ErrorStyle = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='FILE_STYLE']"
		[Register ("FILE_STYLE")]
		public const int FileStyle = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='IMAGE_STYLE']"
		[Register ("IMAGE_STYLE")]
		public const int ImageStyle = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='MINAPP_STYLE']"
		[Register ("MINAPP_STYLE")]
		public const int MinappStyle = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='MUSIC_STYLE']"
		[Register ("MUSIC_STYLE")]
		public const int MusicStyle = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='TEXT_IMAGE_STYLE']"
		[Register ("TEXT_IMAGE_STYLE")]
		public const int TextImageStyle = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='TEXT_STYLE']"
		[Register ("TEXT_STYLE")]
		public const int TextStyle = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='VIDEO_STYLE']"
		[Register ("VIDEO_STYLE")]
		public const int VideoStyle = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='WEB_STYLE']"
		[Register ("WEB_STYLE")]
		public const int WebStyle = (int) 16;

		static IntPtr app_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='app']"
		[Register ("app")]
		public global::Java.IO.File App {
			get {
				if (app_jfieldId == IntPtr.Zero)
					app_jfieldId = JNIEnv.GetFieldID (class_ref, "app", "Ljava/io/File;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, app_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (app_jfieldId == IntPtr.Zero)
					app_jfieldId = JNIEnv.GetFieldID (class_ref, "app", "Ljava/io/File;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, app_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr file_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='file']"
		[Register ("file")]
		public global::Java.IO.File File {
			get {
				if (file_jfieldId == IntPtr.Zero)
					file_jfieldId = JNIEnv.GetFieldID (class_ref, "file", "Ljava/io/File;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, file_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (file_jfieldId == IntPtr.Zero)
					file_jfieldId = JNIEnv.GetFieldID (class_ref, "file", "Ljava/io/File;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, file_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mExtra_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='mExtra']"
		[Register ("mExtra")]
		public global::Com.Umeng.Socialize.Media.IUMediaObject MExtra {
			get {
				if (mExtra_jfieldId == IntPtr.Zero)
					mExtra_jfieldId = JNIEnv.GetFieldID (class_ref, "mExtra", "Lcom/umeng/socialize/media/UMediaObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mExtra_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IUMediaObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mExtra_jfieldId == IntPtr.Zero)
					mExtra_jfieldId = JNIEnv.GetFieldID (class_ref, "mExtra", "Lcom/umeng/socialize/media/UMediaObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mExtra_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFollow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='mFollow']"
		[Register ("mFollow")]
		public string MFollow {
			get {
				if (mFollow_jfieldId == IntPtr.Zero)
					mFollow_jfieldId = JNIEnv.GetFieldID (class_ref, "mFollow", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFollow_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFollow_jfieldId == IntPtr.Zero)
					mFollow_jfieldId = JNIEnv.GetFieldID (class_ref, "mFollow", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFollow_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMedia_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='mMedia']"
		[Register ("mMedia")]
		public global::Com.Umeng.Socialize.Media.IUMediaObject MMedia {
			get {
				if (mMedia_jfieldId == IntPtr.Zero)
					mMedia_jfieldId = JNIEnv.GetFieldID (class_ref, "mMedia", "Lcom/umeng/socialize/media/UMediaObject;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMedia_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IUMediaObject> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMedia_jfieldId == IntPtr.Zero)
					mMedia_jfieldId = JNIEnv.GetFieldID (class_ref, "mMedia", "Lcom/umeng/socialize/media/UMediaObject;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMedia_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mText_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='mText']"
		[Register ("mText")]
		public string MText {
			get {
				if (mText_jfieldId == IntPtr.Zero)
					mText_jfieldId = JNIEnv.GetFieldID (class_ref, "mText", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mText_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mText_jfieldId == IntPtr.Zero)
					mText_jfieldId = JNIEnv.GetFieldID (class_ref, "mText", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mText_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr subject_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/field[@name='subject']"
		[Register ("subject")]
		public string Subject {
			get {
				if (subject_jfieldId == IntPtr.Zero)
					subject_jfieldId = JNIEnv.GetFieldID (class_ref, "subject", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, subject_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (subject_jfieldId == IntPtr.Zero)
					subject_jfieldId = JNIEnv.GetFieldID (class_ref, "subject", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, subject_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/ShareContent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareContent); }
		}

		protected ShareContent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/constructor[@name='ShareContent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ShareContent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ShareContent)) {
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

		static Delegate cb_getShareType;
#pragma warning disable 0169
		static Delegate GetGetShareTypeHandler ()
		{
			if (cb_getShareType == null)
				cb_getShareType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShareType);
			return cb_getShareType;
		}

		static int n_GetShareType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.ShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShareType;
		}
#pragma warning restore 0169

		static IntPtr id_getShareType;
		public virtual unsafe int ShareType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareContent']/method[@name='getShareType' and count(parameter)=0]"
			[Register ("getShareType", "()I", "GetGetShareTypeHandler")]
			get {
				if (id_getShareType == IntPtr.Zero)
					id_getShareType = JNIEnv.GetMethodID (class_ref, "getShareType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getShareType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShareType", "()I"));
				} finally {
				}
			}
		}

	}
}
