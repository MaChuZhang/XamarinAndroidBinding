using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/SocializeProtocolConstants", DoNotGenerateAcw=true)]
	public partial class SocializeProtocolConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='AUTHOR']"
		[Register ("AUTHOR")]
		public const string Author = (string) "author";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='CREATE_AT']"
		[Register ("CREATE_AT")]
		public const string CreateAt = (string) "create_at";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='DISPLAY_NAME']"
		[Register ("DISPLAY_NAME")]
		public const string DisplayName = (string) "display_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='DURATION']"
		[Register ("DURATION")]
		public const string Duration = (string) "duration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='FULL_IMAGE']"
		[Register ("FULL_IMAGE")]
		public const string FullImage = (string) "full_image";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='HEIGHT']"
		[Register ("HEIGHT")]
		public const string Height = (string) "height";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='IMAGE']"
		[Register ("IMAGE")]
		public const string Image = (string) "image";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='LINKS']"
		[Register ("LINKS")]
		public const string Links = (string) "links";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='OBJECT_TYPE']"
		[Register ("OBJECT_TYPE")]
		public const string ObjectType = (string) "object_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_ACCESSTOKEN']"
		[Register ("PROTOCOL_KEY_ACCESSTOKEN")]
		public const string ProtocolKeyAccesstoken = (string) "access_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_AK']"
		[Register ("PROTOCOL_KEY_AK")]
		public const string ProtocolKeyAk = (string) "ak";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_ANDROID_ID']"
		[Register ("PROTOCOL_KEY_ANDROID_ID")]
		public const string ProtocolKeyAndroidId = (string) "android_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_COMMENT_COUNT']"
		[Register ("PROTOCOL_KEY_COMMENT_COUNT")]
		public const string ProtocolKeyCommentCount = (string) "cm";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_COMMENT_TEXT']"
		[Register ("PROTOCOL_KEY_COMMENT_TEXT")]
		public const string ProtocolKeyCommentText = (string) "ct";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_DATA']"
		[Register ("PROTOCOL_KEY_DATA")]
		public const string ProtocolKeyData = (string) "data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_DE']"
		[Register ("PROTOCOL_KEY_DE")]
		public const string ProtocolKeyDe = (string) "de";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_DESCRIPTOR']"
		[Register ("PROTOCOL_KEY_DESCRIPTOR")]
		public const string ProtocolKeyDescriptor = (string) "dc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_DT']"
		[Register ("PROTOCOL_KEY_DT")]
		public const string ProtocolKeyDt = (string) "dt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_EN']"
		[Register ("PROTOCOL_KEY_EN")]
		public const string ProtocolKeyEn = (string) "en";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_ENTITY_KEY']"
		[Register ("PROTOCOL_KEY_ENTITY_KEY")]
		public const string ProtocolKeyEntityKey = (string) "ek";

		static IntPtr PROTOCOL_KEY_ENTITY_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_ENTITY_NAME']"
		[Register ("PROTOCOL_KEY_ENTITY_NAME")]
		public static string ProtocolKeyEntityName {
			get {
				if (PROTOCOL_KEY_ENTITY_NAME_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_ENTITY_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_ENTITY_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_KEY_ENTITY_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PROTOCOL_KEY_ENTITY_NAME_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_ENTITY_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_ENTITY_NAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PROTOCOL_KEY_ENTITY_NAME_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_EXPIRE_IN']"
		[Register ("PROTOCOL_KEY_EXPIRE_IN")]
		public const string ProtocolKeyExpireIn = (string) "expires_in";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_EXPIRE_ON']"
		[Register ("PROTOCOL_KEY_EXPIRE_ON")]
		public const string ProtocolKeyExpireOn = (string) "expire_on";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_EXTEND']"
		[Register ("PROTOCOL_KEY_EXTEND")]
		public const string ProtocolKeyExtend = (string) "ext";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_FR']"
		[Register ("PROTOCOL_KEY_FR")]
		public const string ProtocolKeyFr = (string) "fr";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_FRIST_TIME']"
		[Register ("PROTOCOL_KEY_FRIST_TIME")]
		public const string ProtocolKeyFristTime = (string) "ft";

		static IntPtr PROTOCOL_KEY_FTYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_FTYPE']"
		[Register ("PROTOCOL_KEY_FTYPE")]
		public static string ProtocolKeyFtype {
			get {
				if (PROTOCOL_KEY_FTYPE_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_FTYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_FTYPE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_KEY_FTYPE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PROTOCOL_KEY_FTYPE_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_FTYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_FTYPE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PROTOCOL_KEY_FTYPE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PROTOCOL_KEY_FURL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_FURL']"
		[Register ("PROTOCOL_KEY_FURL")]
		public static string ProtocolKeyFurl {
			get {
				if (PROTOCOL_KEY_FURL_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_FURL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_FURL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_KEY_FURL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PROTOCOL_KEY_FURL_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_FURL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_FURL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PROTOCOL_KEY_FURL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PROTOCOL_KEY_IMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_IMAGE']"
		[Register ("PROTOCOL_KEY_IMAGE")]
		public static string ProtocolKeyImage {
			get {
				if (PROTOCOL_KEY_IMAGE_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_IMAGE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_KEY_IMAGE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PROTOCOL_KEY_IMAGE_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_IMAGE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PROTOCOL_KEY_IMAGE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_IMEI']"
		[Register ("PROTOCOL_KEY_IMEI")]
		public const string ProtocolKeyImei = (string) "imei";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_LIKE_COUNT']"
		[Register ("PROTOCOL_KEY_LIKE_COUNT")]
		public const string ProtocolKeyLikeCount = (string) "lk";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_MAC']"
		[Register ("PROTOCOL_KEY_MAC")]
		public const string ProtocolKeyMac = (string) "mac";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_MD5IMEI']"
		[Register ("PROTOCOL_KEY_MD5IMEI")]
		public const string ProtocolKeyMd5imei = (string) "md5imei";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_MSG']"
		[Register ("PROTOCOL_KEY_MSG")]
		public const string ProtocolKeyMsg = (string) "msg";

		static IntPtr PROTOCOL_KEY_NEW_INSTALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_NEW_INSTALL']"
		[Register ("PROTOCOL_KEY_NEW_INSTALL")]
		public static string ProtocolKeyNewInstall {
			get {
				if (PROTOCOL_KEY_NEW_INSTALL_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_NEW_INSTALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_NEW_INSTALL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_KEY_NEW_INSTALL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PROTOCOL_KEY_NEW_INSTALL_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_NEW_INSTALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_NEW_INSTALL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PROTOCOL_KEY_NEW_INSTALL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_OPENID']"
		[Register ("PROTOCOL_KEY_OPENID")]
		public const string ProtocolKeyOpenid = (string) "openid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_OPID']"
		[Register ("PROTOCOL_KEY_OPID")]
		public const string ProtocolKeyOpid = (string) "opid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_OS']"
		[Register ("PROTOCOL_KEY_OS")]
		public const string ProtocolKeyOs = (string) "os";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_OS_VERSION']"
		[Register ("PROTOCOL_KEY_OS_VERSION")]
		public const string ProtocolKeyOsVersion = (string) "os_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_PLATFORM_ERROR']"
		[Register ("PROTOCOL_KEY_PLATFORM_ERROR")]
		public const string ProtocolKeyPlatformError = (string) "platform_error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_PV']"
		[Register ("PROTOCOL_KEY_PV")]
		public const string ProtocolKeyPv = (string) "pv";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_REQUEST_TYPE']"
		[Register ("PROTOCOL_KEY_REQUEST_TYPE")]
		public const string ProtocolKeyRequestType = (string) "tp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_SHARE_NUM']"
		[Register ("PROTOCOL_KEY_SHARE_NUM")]
		public const string ProtocolKeyShareNum = (string) "sn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_SHARE_SNS']"
		[Register ("PROTOCOL_KEY_SHARE_SNS")]
		public const string ProtocolKeyShareSns = (string) "sns";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_SHARE_TO']"
		[Register ("PROTOCOL_KEY_SHARE_TO")]
		public const string ProtocolKeyShareTo = (string) "to";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_SHARE_USID']"
		[Register ("PROTOCOL_KEY_SHARE_USID")]
		public const string ProtocolKeyShareUsid = (string) "usid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_SID']"
		[Register ("PROTOCOL_KEY_SID")]
		public const string ProtocolKeySid = (string) "sid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_SN']"
		[Register ("PROTOCOL_KEY_SN")]
		public const string ProtocolKeySn = (string) "sn";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_ST']"
		[Register ("PROTOCOL_KEY_ST")]
		public const string ProtocolKeySt = (string) "st";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_TENCENT']"
		[Register ("PROTOCOL_KEY_TENCENT")]
		public const string ProtocolKeyTencent = (string) "tencent";

		static IntPtr PROTOCOL_KEY_THUMB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_THUMB']"
		[Register ("PROTOCOL_KEY_THUMB")]
		public static string ProtocolKeyThumb {
			get {
				if (PROTOCOL_KEY_THUMB_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_THUMB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_THUMB", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_KEY_THUMB_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PROTOCOL_KEY_THUMB_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_THUMB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_THUMB", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PROTOCOL_KEY_THUMB_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PROTOCOL_KEY_TITLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_TITLE']"
		[Register ("PROTOCOL_KEY_TITLE")]
		public static string ProtocolKeyTitle {
			get {
				if (PROTOCOL_KEY_TITLE_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_TITLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_KEY_TITLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PROTOCOL_KEY_TITLE_jfieldId == IntPtr.Zero)
					PROTOCOL_KEY_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_KEY_TITLE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PROTOCOL_KEY_TITLE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_TO']"
		[Register ("PROTOCOL_KEY_TO")]
		public const string ProtocolKeyTo = (string) "to";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_UID']"
		[Register ("PROTOCOL_KEY_UID")]
		public const string ProtocolKeyUid = (string) "uid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_URL']"
		[Register ("PROTOCOL_KEY_URL")]
		public const string ProtocolKeyUrl = (string) "url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_USECOCOS']"
		[Register ("PROTOCOL_KEY_USECOCOS")]
		public const string ProtocolKeyUsecocos = (string) "use_coco2dx";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_VERIFY_MEDIA']"
		[Register ("PROTOCOL_KEY_VERIFY_MEDIA")]
		public const string ProtocolKeyVerifyMedia = (string) "via";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_KEY_VERSION']"
		[Register ("PROTOCOL_KEY_VERSION")]
		public const string ProtocolKeyVersion = (string) "sdkv";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_SHARE_TYPE']"
		[Register ("PROTOCOL_SHARE_TYPE")]
		public const string ProtocolShareType = (string) "type";

		static IntPtr PROTOCOL_VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='PROTOCOL_VERSION']"
		[Register ("PROTOCOL_VERSION")]
		public static string ProtocolVersion {
			get {
				if (PROTOCOL_VERSION_jfieldId == IntPtr.Zero)
					PROTOCOL_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROTOCOL_VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PROTOCOL_VERSION_jfieldId == IntPtr.Zero)
					PROTOCOL_VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROTOCOL_VERSION", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PROTOCOL_VERSION_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='SUMMARY']"
		[Register ("SUMMARY")]
		public const string Summary = (string) "summary";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='TAGS']"
		[Register ("TAGS")]
		public const string Tags = (string) "tags";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='URL']"
		[Register ("URL")]
		public const string Url = (string) "url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/field[@name='WIDTH']"
		[Register ("WIDTH")]
		public const string Width = (string) "width";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/utils/SocializeProtocolConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeProtocolConstants); }
		}

		protected SocializeProtocolConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeProtocolConstants']/constructor[@name='SocializeProtocolConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocializeProtocolConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SocializeProtocolConstants)) {
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
