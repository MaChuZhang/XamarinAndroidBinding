using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Shareboard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SnsPlatform']"
	[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/SnsPlatform", DoNotGenerateAcw=true)]
	public sealed partial class SnsPlatform : global::Java.Lang.Object {


		static IntPtr mGrayIcon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SnsPlatform']/field[@name='mGrayIcon']"
		[Register ("mGrayIcon")]
		public string MGrayIcon {
			get {
				if (mGrayIcon_jfieldId == IntPtr.Zero)
					mGrayIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mGrayIcon", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mGrayIcon_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mGrayIcon_jfieldId == IntPtr.Zero)
					mGrayIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mGrayIcon", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mGrayIcon_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mIcon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SnsPlatform']/field[@name='mIcon']"
		[Register ("mIcon")]
		public string MIcon {
			get {
				if (mIcon_jfieldId == IntPtr.Zero)
					mIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mIcon", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mIcon_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mIcon_jfieldId == IntPtr.Zero)
					mIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mIcon", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIcon_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SnsPlatform']/field[@name='mIndex']"
		[Register ("mIndex")]
		public int MIndex {
			get {
				if (mIndex_jfieldId == IntPtr.Zero)
					mIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mIndex", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mIndex_jfieldId);
			}
			set {
				if (mIndex_jfieldId == IntPtr.Zero)
					mIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mIndex", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIndex_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mKeyword_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SnsPlatform']/field[@name='mKeyword']"
		[Register ("mKeyword")]
		public string MKeyword {
			get {
				if (mKeyword_jfieldId == IntPtr.Zero)
					mKeyword_jfieldId = JNIEnv.GetFieldID (class_ref, "mKeyword", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mKeyword_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mKeyword_jfieldId == IntPtr.Zero)
					mKeyword_jfieldId = JNIEnv.GetFieldID (class_ref, "mKeyword", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mKeyword_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPlatform_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SnsPlatform']/field[@name='mPlatform']"
		[Register ("mPlatform")]
		public global::Com.Umeng.Socialize.Bean.SHARE_MEDIA MPlatform {
			get {
				if (mPlatform_jfieldId == IntPtr.Zero)
					mPlatform_jfieldId = JNIEnv.GetFieldID (class_ref, "mPlatform", "Lcom/umeng/socialize/bean/SHARE_MEDIA;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPlatform_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPlatform_jfieldId == IntPtr.Zero)
					mPlatform_jfieldId = JNIEnv.GetFieldID (class_ref, "mPlatform", "Lcom/umeng/socialize/bean/SHARE_MEDIA;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPlatform_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mShowWord_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SnsPlatform']/field[@name='mShowWord']"
		[Register ("mShowWord")]
		public string MShowWord {
			get {
				if (mShowWord_jfieldId == IntPtr.Zero)
					mShowWord_jfieldId = JNIEnv.GetFieldID (class_ref, "mShowWord", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mShowWord_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mShowWord_jfieldId == IntPtr.Zero)
					mShowWord_jfieldId = JNIEnv.GetFieldID (class_ref, "mShowWord", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mShowWord_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/shareboard/SnsPlatform", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SnsPlatform); }
		}

		internal SnsPlatform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SnsPlatform']/constructor[@name='SnsPlatform' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SnsPlatform (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (SnsPlatform)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='SnsPlatform']/constructor[@name='SnsPlatform' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SnsPlatform ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SnsPlatform)) {
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

	}
}
