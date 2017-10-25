using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/ActionBarResponse", DoNotGenerateAcw=true)]
	public partial class ActionBarResponse : global::Com.Umeng.Socialize.Net.Base.SocializeReseponse {


		static IntPtr mCommentCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mCommentCount']"
		[Register ("mCommentCount")]
		public int MCommentCount {
			get {
				if (mCommentCount_jfieldId == IntPtr.Zero)
					mCommentCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mCommentCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mCommentCount_jfieldId);
			}
			set {
				if (mCommentCount_jfieldId == IntPtr.Zero)
					mCommentCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mCommentCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCommentCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mEntityKey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mEntityKey']"
		[Register ("mEntityKey")]
		public string MEntityKey {
			get {
				if (mEntityKey_jfieldId == IntPtr.Zero)
					mEntityKey_jfieldId = JNIEnv.GetFieldID (class_ref, "mEntityKey", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mEntityKey_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mEntityKey_jfieldId == IntPtr.Zero)
					mEntityKey_jfieldId = JNIEnv.GetFieldID (class_ref, "mEntityKey", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEntityKey_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFavorite_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mFavorite']"
		[Register ("mFavorite")]
		public int MFavorite {
			get {
				if (mFavorite_jfieldId == IntPtr.Zero)
					mFavorite_jfieldId = JNIEnv.GetFieldID (class_ref, "mFavorite", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFavorite_jfieldId);
			}
			set {
				if (mFavorite_jfieldId == IntPtr.Zero)
					mFavorite_jfieldId = JNIEnv.GetFieldID (class_ref, "mFavorite", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFavorite_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFirstTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mFirstTime']"
		[Register ("mFirstTime")]
		public int MFirstTime {
			get {
				if (mFirstTime_jfieldId == IntPtr.Zero)
					mFirstTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mFirstTime", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFirstTime_jfieldId);
			}
			set {
				if (mFirstTime_jfieldId == IntPtr.Zero)
					mFirstTime_jfieldId = JNIEnv.GetFieldID (class_ref, "mFirstTime", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFirstTime_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mLikeCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mLikeCount']"
		[Register ("mLikeCount")]
		public int MLikeCount {
			get {
				if (mLikeCount_jfieldId == IntPtr.Zero)
					mLikeCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mLikeCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mLikeCount_jfieldId);
			}
			set {
				if (mLikeCount_jfieldId == IntPtr.Zero)
					mLikeCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mLikeCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLikeCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mPv_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mPv']"
		[Register ("mPv")]
		public int MPv {
			get {
				if (mPv_jfieldId == IntPtr.Zero)
					mPv_jfieldId = JNIEnv.GetFieldID (class_ref, "mPv", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mPv_jfieldId);
			}
			set {
				if (mPv_jfieldId == IntPtr.Zero)
					mPv_jfieldId = JNIEnv.GetFieldID (class_ref, "mPv", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPv_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mShareCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mShareCount']"
		[Register ("mShareCount")]
		public int MShareCount {
			get {
				if (mShareCount_jfieldId == IntPtr.Zero)
					mShareCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mShareCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mShareCount_jfieldId);
			}
			set {
				if (mShareCount_jfieldId == IntPtr.Zero)
					mShareCount_jfieldId = JNIEnv.GetFieldID (class_ref, "mShareCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mShareCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mSid']"
		[Register ("mSid")]
		public string MSid {
			get {
				if (mSid_jfieldId == IntPtr.Zero)
					mSid_jfieldId = JNIEnv.GetFieldID (class_ref, "mSid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSid_jfieldId == IntPtr.Zero)
					mSid_jfieldId = JNIEnv.GetFieldID (class_ref, "mSid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mUid']"
		[Register ("mUid")]
		public string MUid {
			get {
				if (mUid_jfieldId == IntPtr.Zero)
					mUid_jfieldId = JNIEnv.GetFieldID (class_ref, "mUid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mUid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUid_jfieldId == IntPtr.Zero)
					mUid_jfieldId = JNIEnv.GetFieldID (class_ref, "mUid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUk_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/field[@name='mUk']"
		[Register ("mUk")]
		public string MUk {
			get {
				if (mUk_jfieldId == IntPtr.Zero)
					mUk_jfieldId = JNIEnv.GetFieldID (class_ref, "mUk", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mUk_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUk_jfieldId == IntPtr.Zero)
					mUk_jfieldId = JNIEnv.GetFieldID (class_ref, "mUk", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUk_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/ActionBarResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionBarResponse); }
		}

		protected ActionBarResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='ActionBarResponse']/constructor[@name='ActionBarResponse' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", "")]
		public unsafe ActionBarResponse (global::Java.Lang.Integer p0, global::Org.Json.JSONObject p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ActionBarResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

	}
}
