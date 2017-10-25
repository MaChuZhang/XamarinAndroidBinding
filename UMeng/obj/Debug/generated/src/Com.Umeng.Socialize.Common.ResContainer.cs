using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']"
	[global::Android.Runtime.Register ("com/umeng/socialize/common/ResContainer", DoNotGenerateAcw=true)]
	public sealed partial class ResContainer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer.SocializeResource']"
		[global::Android.Runtime.Register ("com/umeng/socialize/common/ResContainer$SocializeResource", DoNotGenerateAcw=true)]
		public partial class SocializeResource : global::Java.Lang.Object {


			static IntPtr mId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer.SocializeResource']/field[@name='mId']"
			[Register ("mId")]
			public int MId {
				get {
					if (mId_jfieldId == IntPtr.Zero)
						mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mId_jfieldId);
				}
				set {
					if (mId_jfieldId == IntPtr.Zero)
						mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mIsCompleted_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer.SocializeResource']/field[@name='mIsCompleted']"
			[Register ("mIsCompleted")]
			public bool MIsCompleted {
				get {
					if (mIsCompleted_jfieldId == IntPtr.Zero)
						mIsCompleted_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsCompleted", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mIsCompleted_jfieldId);
				}
				set {
					if (mIsCompleted_jfieldId == IntPtr.Zero)
						mIsCompleted_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsCompleted", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIsCompleted_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer.SocializeResource']/field[@name='mName']"
			[Register ("mName")]
			public string MName {
				get {
					if (mName_jfieldId == IntPtr.Zero)
						mName_jfieldId = JNIEnv.GetFieldID (class_ref, "mName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mName_jfieldId == IntPtr.Zero)
						mName_jfieldId = JNIEnv.GetFieldID (class_ref, "mName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr mType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer.SocializeResource']/field[@name='mType']"
			[Register ("mType")]
			public string MType {
				get {
					if (mType_jfieldId == IntPtr.Zero)
						mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mType_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mType_jfieldId == IntPtr.Zero)
						mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mType_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/common/ResContainer$SocializeResource", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SocializeResource); }
			}

			protected SocializeResource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer.SocializeResource']/constructor[@name='ResContainer.SocializeResource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe SocializeResource (string p0, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (SocializeResource)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/common/ResContainer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResContainer); }
		}

		internal ResContainer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/constructor[@name='ResContainer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, com.umeng.socialize.common.ResContainer.SocializeResource&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/Map;)V", "")]
		public unsafe ResContainer (global::Android.Content.Context p0, global::System.Collections.Generic.IDictionary<string, global::Com.Umeng.Socialize.Common.ResContainer.SocializeResource> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Com.Umeng.Socialize.Common.ResContainer.SocializeResource>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (ResContainer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_anim_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='anim' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("anim", "(Ljava/lang/String;)I", "")]
		public unsafe int Anim (string p0)
		{
			if (id_anim_Ljava_lang_String_ == IntPtr.Zero)
				id_anim_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "anim", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_anim_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_batch;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='batch' and count(parameter)=0]"
		[Register ("batch", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Umeng.Socialize.Common.ResContainer.SocializeResource> Batch ()
		{
			if (id_batch == IntPtr.Zero)
				id_batch = JNIEnv.GetMethodID (class_ref, "batch", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, global::Com.Umeng.Socialize.Common.ResContainer.SocializeResource>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_batch), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_color_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='color' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("color", "(Ljava/lang/String;)I", "")]
		public unsafe int Color (string p0)
		{
			if (id_color_Ljava_lang_String_ == IntPtr.Zero)
				id_color_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "color", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_color_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_dimen_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='dimen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dimen", "(Ljava/lang/String;)I", "")]
		public unsafe int Dimen (string p0)
		{
			if (id_dimen_Ljava_lang_String_ == IntPtr.Zero)
				id_dimen_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "dimen", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_dimen_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_drawable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='drawable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("drawable", "(Ljava/lang/String;)I", "")]
		public unsafe int Drawable (string p0)
		{
			if (id_drawable_Ljava_lang_String_ == IntPtr.Zero)
				id_drawable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "drawable", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_drawable_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_get_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='get' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("get", "(Landroid/content/Context;)Lcom/umeng/socialize/common/ResContainer;", "")]
		public static unsafe global::Com.Umeng.Socialize.Common.ResContainer Get (global::Android.Content.Context p0)
		{
			if (id_get_Landroid_content_Context_ == IntPtr.Zero)
				id_get_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Landroid/content/Context;)Lcom/umeng/socialize/common/ResContainer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Umeng.Socialize.Common.ResContainer __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Common.ResContainer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getResourceId_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='getResourceId' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getResourceId", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int GetResourceId (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getResourceId_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getResourceId_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getResourceId", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getResourceId_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getString_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetString (global::Android.Content.Context p0, string p1)
		{
			if (id_getString_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getStyleableArrts_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='getStyleableArrts' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStyleableArrts", "(Landroid/content/Context;Ljava/lang/String;)[I", "")]
		public static unsafe int[] GetStyleableArrts (global::Android.Content.Context p0, string p1)
		{
			if (id_getStyleableArrts_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getStyleableArrts_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStyleableArrts", "(Landroid/content/Context;Ljava/lang/String;)[I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStyleableArrts_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_id_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='id' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("id", "(Ljava/lang/String;)I", "")]
		public unsafe int Id (string p0)
		{
			if (id_id_Ljava_lang_String_ == IntPtr.Zero)
				id_id_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "id", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_id_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_layout_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='layout' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("layout", "(Ljava/lang/String;)I", "")]
		public unsafe int Layout (string p0)
		{
			if (id_layout_Ljava_lang_String_ == IntPtr.Zero)
				id_layout_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "layout", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_layout_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_raw_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='raw' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("raw", "(Ljava/lang/String;)I", "")]
		public unsafe int Raw (string p0)
		{
			if (id_raw_Ljava_lang_String_ == IntPtr.Zero)
				id_raw_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "raw", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_raw_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_string_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='string' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("string", "(Ljava/lang/String;)I", "")]
		public unsafe int String (string p0)
		{
			if (id_string_Ljava_lang_String_ == IntPtr.Zero)
				id_string_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "string", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_string_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_style_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='style' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("style", "(Ljava/lang/String;)I", "")]
		public unsafe int Style (string p0)
		{
			if (id_style_Ljava_lang_String_ == IntPtr.Zero)
				id_style_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "style", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_style_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_styleable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='ResContainer']/method[@name='styleable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("styleable", "(Ljava/lang/String;)I", "")]
		public unsafe int Styleable (string p0)
		{
			if (id_styleable_Ljava_lang_String_ == IntPtr.Zero)
				id_styleable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "styleable", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_styleable_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
