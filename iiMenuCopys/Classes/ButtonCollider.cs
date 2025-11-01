using System;
using MelonLoader;
using UnityEngine;
using Main = iiMenu.Menu.Main;

/*
 *  HEY SKIDDERS
 *  ignore this fuckass dnspy mess
*/

namespace iiMenu.Classes
{
    // Token: 0x02000018 RID: 24
    [RegisterTypeInIl2Cpp]
    public class Button : MonoBehaviour
    {
        // Token: 0x06000523 RID: 1315 RVA: 0x00003DD0 File Offset: 0x00001FD0
        public Button(IntPtr ptr) : base(ptr)
        {
        }

        // Token: 0x06000524 RID: 1316 RVA: 0x00023394 File Offset: 0x00021594
        public void OnTriggerEnter(Collider collider)
        {
            if (Time.time > Button.buttonCooldown && collider == Main.buttonCollider && Main.menu != null)
            {
                Button.buttonCooldown = Time.time + 0.2f;
                //GorillaTagger.Instance.StartVibration(Main.GetIndex("Right Hand").enabled, GorillaTagger.Instance.tagHapticStrength / 2f, GorillaTagger.Instance.tagHapticDuration / 2f);
                Main.Toggle(this.relatedText);
            }
            //MelonLoader.MelonLogger.Msg("Test123");
        }

        // Token: 0x06000525 RID: 1317 RVA: 0x0000246F File Offset: 0x0000066F
        static float smethod_0()
        {
            return Time.time;
        }

        // Token: 0x06000526 RID: 1318 RVA: 0x00002D49 File Offset: 0x00000F49
        static bool smethod_1(UnityEngine.Object object_0, UnityEngine.Object object_1)
        {
            return object_0 == object_1;
        }

        // Token: 0x06000527 RID: 1319 RVA: 0x00002DF4 File Offset: 0x00000FF4
        static bool smethod_2(UnityEngine.Object object_0, UnityEngine.Object object_1)
        {
            return object_0 != object_1;
        }

        // Token: 0x06000528 RID: 1320 RVA: 0x00002255 File Offset: 0x00000455
        static GorillaTagger smethod_3()
        {
            return GorillaTagger.Instance;
        }

        // Token: 0x06000529 RID: 1321 RVA: 0x00003DE4 File Offset: 0x00001FE4
        static float smethod_4(GorillaTagger gorillaTagger_0)
        {
            return gorillaTagger_0.tagHapticStrength;
        }

        // Token: 0x0600052A RID: 1322 RVA: 0x00003DEC File Offset: 0x00001FEC
        static float smethod_5(GorillaTagger gorillaTagger_0)
        {
            return gorillaTagger_0.tagHapticDuration;
        }

        // Token: 0x0600052B RID: 1323 RVA: 0x00003DF4 File Offset: 0x00001FF4
        static void smethod_6(GorillaTagger gorillaTagger_0, bool bool_0, float float_0, float float_1)
        {
            gorillaTagger_0.StartVibration(bool_0, float_0, float_1);
        }

        // Token: 0x0600052C RID: 1324 RVA: 0x00003DFF File Offset: 0x00001FFF
        static void smethod_7(MelonLogger.Instance instance_0, string string_0)
        {
            instance_0.Msg(string_0);
        }

        // Token: 0x040000AC RID: 172
        public string relatedText = "";

        // Token: 0x040000AD RID: 173
        public static float buttonCooldown;
    }
}
