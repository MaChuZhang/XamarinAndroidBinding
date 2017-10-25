using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']"
	[global::Android.Runtime.Register ("com/umeng/socialize/UMShareConfig", DoNotGenerateAcw=true)]
	public sealed partial class UMShareConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/field[@name='AUTH_TYPE_SSO']"
		[Register ("AUTH_TYPE_SSO")]
		public const int AuthTypeSso = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/field[@name='AUTH_TYPE_WEBVIEW']"
		[Register ("AUTH_TYPE_WEBVIEW")]
		public const int AuthTypeWebview = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/field[@name='KAKAO_ACCOUNT']"
		[Register ("KAKAO_ACCOUNT")]
		public const int KakaoAccount = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/field[@name='KAKAO_STORY']"
		[Register ("KAKAO_STORY")]
		public const int KakaoStory = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/field[@name='KAKAO_TALK']"
		[Register ("KAKAO_TALK")]
		public const int KakaoTalk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/field[@name='LINED_IN_BASE_PROFILE']"
		[Register ("LINED_IN_BASE_PROFILE")]
		public const int LinedInBaseProfile = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/field[@name='LINED_IN_FULL_PROFILE']"
		[Register ("LINED_IN_FULL_PROFILE")]
		public const int LinedInFullProfile = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/field[@name='LINKED_IN_FRIEND_SCOPE_ANYONE']"
		[Register ("LINKED_IN_FRIEND_SCOPE_ANYONE")]
		public const int LinkedInFriendScopeAnyone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/field[@name='LINKED_IN_FRIEND_SCOPE_CONNECTIONS']"
		[Register ("LINKED_IN_FRIEND_SCOPE_CONNECTIONS")]
		public const int LinkedInFriendScopeConnections = (int) 1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/UMShareConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMShareConfig); }
		}

		internal UMShareConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/constructor[@name='UMShareConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UMShareConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UMShareConfig)) {
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

		static IntPtr id_getAppName;
		public unsafe string AppName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='getAppName' and count(parameter)=0]"
			[Register ("getAppName", "()Ljava/lang/String;", "GetGetAppNameHandler")]
			get {
				if (id_getAppName == IntPtr.Zero)
					id_getAppName = JNIEnv.GetMethodID (class_ref, "getAppName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isFacebookAuthWithWebView;
		public unsafe bool IsFacebookAuthWithWebView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isFacebookAuthWithWebView' and count(parameter)=0]"
			[Register ("isFacebookAuthWithWebView", "()Z", "GetIsFacebookAuthWithWebViewHandler")]
			get {
				if (id_isFacebookAuthWithWebView == IntPtr.Zero)
					id_isFacebookAuthWithWebView = JNIEnv.GetMethodID (class_ref, "isFacebookAuthWithWebView", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFacebookAuthWithWebView);
				} finally {
				}
			}
		}

		static IntPtr id_isHideQzoneOnQQFriendList;
		public unsafe bool IsHideQzoneOnQQFriendList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isHideQzoneOnQQFriendList' and count(parameter)=0]"
			[Register ("isHideQzoneOnQQFriendList", "()Z", "GetIsHideQzoneOnQQFriendListHandler")]
			get {
				if (id_isHideQzoneOnQQFriendList == IntPtr.Zero)
					id_isHideQzoneOnQQFriendList = JNIEnv.GetMethodID (class_ref, "isHideQzoneOnQQFriendList", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideQzoneOnQQFriendList);
				} finally {
				}
			}
		}

		static IntPtr id_isKakaoAuthWithAccount;
		public unsafe bool IsKakaoAuthWithAccount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isKakaoAuthWithAccount' and count(parameter)=0]"
			[Register ("isKakaoAuthWithAccount", "()Z", "GetIsKakaoAuthWithAccountHandler")]
			get {
				if (id_isKakaoAuthWithAccount == IntPtr.Zero)
					id_isKakaoAuthWithAccount = JNIEnv.GetMethodID (class_ref, "isKakaoAuthWithAccount", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isKakaoAuthWithAccount);
				} finally {
				}
			}
		}

		static IntPtr id_isKakaoAuthWithStory;
		public unsafe bool IsKakaoAuthWithStory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isKakaoAuthWithStory' and count(parameter)=0]"
			[Register ("isKakaoAuthWithStory", "()Z", "GetIsKakaoAuthWithStoryHandler")]
			get {
				if (id_isKakaoAuthWithStory == IntPtr.Zero)
					id_isKakaoAuthWithStory = JNIEnv.GetMethodID (class_ref, "isKakaoAuthWithStory", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isKakaoAuthWithStory);
				} finally {
				}
			}
		}

		static IntPtr id_isKakaoAuthWithTalk;
		public unsafe bool IsKakaoAuthWithTalk {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isKakaoAuthWithTalk' and count(parameter)=0]"
			[Register ("isKakaoAuthWithTalk", "()Z", "GetIsKakaoAuthWithTalkHandler")]
			get {
				if (id_isKakaoAuthWithTalk == IntPtr.Zero)
					id_isKakaoAuthWithTalk = JNIEnv.GetMethodID (class_ref, "isKakaoAuthWithTalk", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isKakaoAuthWithTalk);
				} finally {
				}
			}
		}

		static IntPtr id_isLinkedInProfileBase;
		public unsafe bool IsLinkedInProfileBase {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isLinkedInProfileBase' and count(parameter)=0]"
			[Register ("isLinkedInProfileBase", "()Z", "GetIsLinkedInProfileBaseHandler")]
			get {
				if (id_isLinkedInProfileBase == IntPtr.Zero)
					id_isLinkedInProfileBase = JNIEnv.GetMethodID (class_ref, "isLinkedInProfileBase", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLinkedInProfileBase);
				} finally {
				}
			}
		}

		static IntPtr id_isLinkedInShareToAnyone;
		public unsafe bool IsLinkedInShareToAnyone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isLinkedInShareToAnyone' and count(parameter)=0]"
			[Register ("isLinkedInShareToAnyone", "()Z", "GetIsLinkedInShareToAnyoneHandler")]
			get {
				if (id_isLinkedInShareToAnyone == IntPtr.Zero)
					id_isLinkedInShareToAnyone = JNIEnv.GetMethodID (class_ref, "isLinkedInShareToAnyone", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLinkedInShareToAnyone);
				} finally {
				}
			}
		}

		static IntPtr id_isNeedAuthOnGetUserInfo;
		public unsafe bool IsNeedAuthOnGetUserInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isNeedAuthOnGetUserInfo' and count(parameter)=0]"
			[Register ("isNeedAuthOnGetUserInfo", "()Z", "GetIsNeedAuthOnGetUserInfoHandler")]
			get {
				if (id_isNeedAuthOnGetUserInfo == IntPtr.Zero)
					id_isNeedAuthOnGetUserInfo = JNIEnv.GetMethodID (class_ref, "isNeedAuthOnGetUserInfo", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNeedAuthOnGetUserInfo);
				} finally {
				}
			}
		}

		static IntPtr id_isOpenShareEditActivity;
		public unsafe bool IsOpenShareEditActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isOpenShareEditActivity' and count(parameter)=0]"
			[Register ("isOpenShareEditActivity", "()Z", "GetIsOpenShareEditActivityHandler")]
			get {
				if (id_isOpenShareEditActivity == IntPtr.Zero)
					id_isOpenShareEditActivity = JNIEnv.GetMethodID (class_ref, "isOpenShareEditActivity", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpenShareEditActivity);
				} finally {
				}
			}
		}

		static IntPtr id_isSinaAuthWithWebView;
		public unsafe bool IsSinaAuthWithWebView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isSinaAuthWithWebView' and count(parameter)=0]"
			[Register ("isSinaAuthWithWebView", "()Z", "GetIsSinaAuthWithWebViewHandler")]
			get {
				if (id_isSinaAuthWithWebView == IntPtr.Zero)
					id_isSinaAuthWithWebView = JNIEnv.GetMethodID (class_ref, "isSinaAuthWithWebView", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSinaAuthWithWebView);
				} finally {
				}
			}
		}

		static IntPtr id_isNeedAuthOnGetUserInfo_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isNeedAuthOnGetUserInfo' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isNeedAuthOnGetUserInfo", "(Z)Lcom/umeng/socialize/UMShareConfig;", "")]
		public unsafe global::Com.Umeng.Socialize.UMShareConfig InvokeIsNeedAuthOnGetUserInfo (bool p0)
		{
			if (id_isNeedAuthOnGetUserInfo_Z == IntPtr.Zero)
				id_isNeedAuthOnGetUserInfo_Z = JNIEnv.GetMethodID (class_ref, "isNeedAuthOnGetUserInfo", "(Z)Lcom/umeng/socialize/UMShareConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isNeedAuthOnGetUserInfo_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_isOpenShareEditActivity_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='isOpenShareEditActivity' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isOpenShareEditActivity", "(Z)Lcom/umeng/socialize/UMShareConfig;", "")]
		public unsafe global::Com.Umeng.Socialize.UMShareConfig InvokeIsOpenShareEditActivity (bool p0)
		{
			if (id_isOpenShareEditActivity_Z == IntPtr.Zero)
				id_isOpenShareEditActivity_Z = JNIEnv.GetMethodID (class_ref, "isOpenShareEditActivity", "(Z)Lcom/umeng/socialize/UMShareConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isOpenShareEditActivity_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setFacebookAuthType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='setFacebookAuthType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFacebookAuthType", "(I)Lcom/umeng/socialize/UMShareConfig;", "")]
		public unsafe global::Com.Umeng.Socialize.UMShareConfig SetFacebookAuthType (int p0)
		{
			if (id_setFacebookAuthType_I == IntPtr.Zero)
				id_setFacebookAuthType_I = JNIEnv.GetMethodID (class_ref, "setFacebookAuthType", "(I)Lcom/umeng/socialize/UMShareConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFacebookAuthType_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setKaKaoAuthType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='setKaKaoAuthType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setKaKaoAuthType", "(I)Lcom/umeng/socialize/UMShareConfig;", "")]
		public unsafe global::Com.Umeng.Socialize.UMShareConfig SetKaKaoAuthType (int p0)
		{
			if (id_setKaKaoAuthType_I == IntPtr.Zero)
				id_setKaKaoAuthType_I = JNIEnv.GetMethodID (class_ref, "setKaKaoAuthType", "(I)Lcom/umeng/socialize/UMShareConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setKaKaoAuthType_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setLinkedInProfileScope_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='setLinkedInProfileScope' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLinkedInProfileScope", "(I)Lcom/umeng/socialize/UMShareConfig;", "")]
		public unsafe global::Com.Umeng.Socialize.UMShareConfig SetLinkedInProfileScope (int p0)
		{
			if (id_setLinkedInProfileScope_I == IntPtr.Zero)
				id_setLinkedInProfileScope_I = JNIEnv.GetMethodID (class_ref, "setLinkedInProfileScope", "(I)Lcom/umeng/socialize/UMShareConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLinkedInProfileScope_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setShareToLinkedInFriendScope_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='setShareToLinkedInFriendScope' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setShareToLinkedInFriendScope", "(I)Lcom/umeng/socialize/UMShareConfig;", "")]
		public unsafe global::Com.Umeng.Socialize.UMShareConfig SetShareToLinkedInFriendScope (int p0)
		{
			if (id_setShareToLinkedInFriendScope_I == IntPtr.Zero)
				id_setShareToLinkedInFriendScope_I = JNIEnv.GetMethodID (class_ref, "setShareToLinkedInFriendScope", "(I)Lcom/umeng/socialize/UMShareConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShareToLinkedInFriendScope_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setShareToQQFriendQzoneItemHide_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='setShareToQQFriendQzoneItemHide' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShareToQQFriendQzoneItemHide", "(Z)Lcom/umeng/socialize/UMShareConfig;", "")]
		public unsafe global::Com.Umeng.Socialize.UMShareConfig SetShareToQQFriendQzoneItemHide (bool p0)
		{
			if (id_setShareToQQFriendQzoneItemHide_Z == IntPtr.Zero)
				id_setShareToQQFriendQzoneItemHide_Z = JNIEnv.GetMethodID (class_ref, "setShareToQQFriendQzoneItemHide", "(Z)Lcom/umeng/socialize/UMShareConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShareToQQFriendQzoneItemHide_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setShareToQQPlatformName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='setShareToQQPlatformName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setShareToQQPlatformName", "(Ljava/lang/String;)Lcom/umeng/socialize/UMShareConfig;", "")]
		public unsafe global::Com.Umeng.Socialize.UMShareConfig SetShareToQQPlatformName (string p0)
		{
			if (id_setShareToQQPlatformName_Ljava_lang_String_ == IntPtr.Zero)
				id_setShareToQQPlatformName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setShareToQQPlatformName", "(Ljava/lang/String;)Lcom/umeng/socialize/UMShareConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Umeng.Socialize.UMShareConfig __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShareToQQPlatformName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setSinaAuthType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='UMShareConfig']/method[@name='setSinaAuthType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSinaAuthType", "(I)Lcom/umeng/socialize/UMShareConfig;", "")]
		public unsafe global::Com.Umeng.Socialize.UMShareConfig SetSinaAuthType (int p0)
		{
			if (id_setSinaAuthType_I == IntPtr.Zero)
				id_setSinaAuthType_I = JNIEnv.GetMethodID (class_ref, "setSinaAuthType", "(I)Lcom/umeng/socialize/UMShareConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSinaAuthType_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
