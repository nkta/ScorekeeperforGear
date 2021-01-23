S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.2
Build-Number: R732XXU2EQC1
Build-Date: 2017.03.13 20:32:41

Crash Information
Process Name: scorekeeperforgear
PID: 3847
Date: 2017-06-25 22:21:56+0200
Executable File Path: /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x60

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbee5245c, r5   = 0x41392980
r6   = 0x00000274, r7   = 0x41392e0f
r8   = 0x418a1bd8, r9   = 0x00000f07
r10  = 0x41818688, fp   = 0x00000000
ip   = 0x40fb2140, sp   = 0xbee51c50
lr   = 0x41391bf9, pc   = 0x416b6118
cpsr = 0x60000030

Memory Information
MemTotal:   491132 KB
MemFree:      8772 KB
Buffers:     16708 KB
Cached:     132436 KB
VmPeak:     119348 KB
VmSize:     119344 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18372 KB
VmRSS:       18368 KB
VmData:      59756 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23316 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 7
PID = 3847 TID = 3847
3847 3867 3868 3869 3870 3872 3873 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f2000 40309000 r-xp /usr/lib/libecore.so.1.7.99
40320000 4037e000 r-xp /usr/lib/libedje.so.1.7.99
40388000 40458000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40459000 4045f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40467000 4046b000 r-xp /usr/lib/libsmack.so.1.0.0
40474000 4047c000 r-xp /lib/libgcc_s-4.6.so.1
4047d000 405a1000 r-xp /lib/libc-2.13.so
405af000 405cd000 r-xp /usr/lib/libsystemd.so.0.4.0
405d7000 405e2000 r-xp /lib/libunwind.so.8.0.1
4060f000 40626000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062e000 40658000 r-xp /usr/lib/libdbus-1.so.3.8.12
40661000 40666000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066e000 40691000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40699000 4069a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a2000 406a8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b1000 4071a000 r-xp /lib/libm-2.13.so
40723000 4073c000 r-xp /usr/lib/libeet.so.1.7.99
4074d000 4078e000 r-xp /usr/lib/libeina.so.1.7.99
40797000 407b9000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c2000 407c7000 r-xp /usr/lib/libecore_file.so.1.7.99
407cf000 407e0000 r-xp /usr/lib/libecore_input.so.1.7.99
407e8000 407f1000 r-xp /usr/lib/libvconf.so.0.2.45
407f9000 40849000 r-xp /usr/lib/libecore_x.so.1.7.99
4084b000 40854000 r-xp /usr/lib/libedbus.so.1.7.99
4085c000 40876000 r-xp /usr/lib/libecore_con.so.1.7.99
4087f000 40892000 r-xp /usr/lib/libfribidi.so.0.3.1
4089a000 408df000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a5a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a62000 40a65000 r-xp /lib/libcap.so.2.21
40a6d000 40a85000 r-xp /usr/lib/liblzma.so.5.0.3
40a8d000 40a9d000 r-xp /lib/libresolv-2.13.so
40aa1000 40b74000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b7f000 40bb3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbc000 40bd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bde000 40c53000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5d000 40c5f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c67000 40c7d000 r-xp /lib/libz.so.1.2.5
40c85000 40ca8000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc0000 40da1000 r-xp /usr/lib/libX11.so.6.3.0
40dac000 40db1000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dba000 40dbe000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc7000 40dca000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd2000 40dd9000 r-xp /usr/lib/libXcursor.so.1.0.2
40de1000 40de3000 r-xp /usr/lib/libXdamage.so.1.1.0
40deb000 40ded000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df5000 40df7000 r-xp /usr/lib/libXgesture.so.7.0.0
40dff000 40e02000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0a000 40e13000 r-xp /usr/lib/libXi.so.6.1.0
40e1b000 40e1c000 r-xp /usr/lib/libXinerama.so.1.0.0
40e25000 40e2b000 r-xp /usr/lib/libXrandr.so.2.2.0
40e33000 40e39000 r-xp /usr/lib/libXrender.so.1.3.0
40e41000 40e45000 r-xp /usr/lib/libXtst.so.6.1.0
40e4d000 40e57000 r-xp /usr/lib/libXext.so.6.4.0
40e60000 40ea4000 r-xp /usr/lib/libcurl.so.4.3.0
40ead000 40ec3000 r-xp /lib/libexpat.so.1.6.0
40ecd000 40ee5000 r-xp /usr/lib/libpng12.so.0.50.0
40eed000 40f0a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f13000 40fa7000 r-xp /usr/lib/libstdc++.so.6.0.16
40fba000 40fbd000 r-xp /lib/libattr.so.1.1.0
40fc5000 40fc6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fce000 40fd3000 r-xp /usr/lib/libffi.so.5.0.10
40fdc000 40fde000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe6000 410b2000 r-xp /usr/lib/libxml2.so.2.7.8
410bf000 410c1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410ca000 410cc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d4000 410e7000 r-xp /usr/lib/libxcb.so.1.1.0
410f1000 410fa000 r-xp /usr/lib/libcares.so.2.1.0
41103000 41131000 r-xp /usr/lib/libidn.so.11.5.44
41139000 41180000 r-xp /usr/lib/libssl.so.1.0.0
4118c000 4131e000 r-xp /usr/lib/libcrypto.so.1.0.0
41340000 41342000 r-xp /usr/lib/libiri.so
4134a000 41351000 r-xp /lib/libcrypt-2.13.so
41381000 41383000 r-xp /usr/lib/libXau.so.6.0.0
41390000 41394000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139c000 413a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a6000 413ab000 r-xp /usr/lib/libappcore-common.so.1.1
413b3000 413b5000 r-xp /usr/lib/libiniparser.so.0
413be000 413c9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
413d4000 413d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e1000 413e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ec000 413f2000 r-xp /usr/lib/libappsvc.so.0.1.0
413fa000 4141e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41427000 414f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150c000 41516000 r-xp /lib/libnss_files-2.13.so
416b2000 416bc000 r-xp /opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear
416cd000 416d2000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
416da000 416e6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416ef000 41710000 r-xp /usr/lib/libefl-extension.so.0.1.0
41718000 4171d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41725000 4174f000 r-xp /usr/lib/libsensor.so.1.9.5
41758000 4175f000 r-xp /usr/lib/libctx-shared.so.0.8.3
4176e000 418a2000 rw-p [heap]
418a2000 418a7000 r-xp /usr/lib/libctx-client.so.0.8.3
418af000 418c1000 r-xp /usr/lib/libefl-assist.so.0.1.0
418c9000 41981000 r-xp /usr/lib/libcairo.so.2.11200.14
4198c000 41996000 r-xp /usr/lib/libsensord-shared.so
4199e000 419ad000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
419b6000 419cc000 r-xp /usr/lib/libtts.so
419d5000 419f8000 r-xp /usr/lib/libui-extension.so.0.1.0
41a01000 41a0c000 r-xp /usr/lib/libtbm.so.1.0.0
41a14000 41a22000 r-xp /usr/lib/libGLESv2.so.2.0
41a2b000 41a2c000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a35000 41a3b000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a43000 41a46000 r-xp /usr/lib/libEGL.so.1.4
41a4e000 41a51000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a59000 41a5a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a63000 41beb000 r-xp /usr/lib/libicui18n.so.57.1
41bfb000 41d01000 r-xp /usr/lib/libicuuc.so.57.1
41d17000 41d1f000 r-xp /usr/lib/libdrm.so.2.4.0
41d27000 41d29000 r-xp /usr/lib/libdri2.so.0.0.0
41d31000 41d37000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d3f000 41d44000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d4c000 41d65000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43606000 43627000 r-xp /usr/lib/libexif.so.12.3.3
4363a000 4363c000 r-xp /usr/lib/libttrace.so.1.1
43644000 43649000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43651000 43657000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43660000 43668000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43670000 43692000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4369b000 436a2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
436ab000 436ad000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
436b5000 436bc000 r-xp /usr/lib/libminizip.so.1.0.0
436c4000 436d1000 r-xp /usr/lib/libail.so.0.1.0
436da000 436e0000 r-xp /usr/lib/libproc-stat.so.0.2.96
436e8000 436e9000 r-xp /usr/lib/libresponse.so.0.2.96
436f1000 436f6000 r-xp /usr/lib/libsystem.so.0.0.0
43700000 437ca000 r-xp /usr/lib/libCOREGL.so.4.0
43bfc000 443fb000 rw-p [stack:3867]
443fc000 44bfb000 rw-p [stack:3868]
44bfc000 453fb000 rw-p [stack:3869]
453fb000 45406000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4540f000 45414000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4541d000 45c1c000 rw-p [stack:3870]
45c1c000 45c33000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
45c40000 45c42000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45c4b000 4644a000 rw-p [stack:3872]
4644a000 4644b000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
4660b000 4745c000 rw-p [stack:3873]
bee32000 bee53000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3847)
Call Stack Count: 18
 0: resume_viewScore() + 0xb (0x416b6118) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x4118
 1: (0x41391bf9) [/usr/lib/libcapi-appfw-application.so.0] + 0x1bf9
 2: (0x400441ed) [/usr/lib/libappcore-efl.so.1] + 0x31ed
 3: (0x413a7d1f) [/usr/lib/libappcore-common.so.1] + 0x1d1f
 4: (0x4005a495) [/usr/lib/libaul.so.0] + 0x4495
 5: (0x4005afad) [/usr/lib/libaul.so.0] + 0x4fad
 6: (0x403bbfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 7: g_main_context_dispatch + 0xbc (0x403bd7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 8: (0x40302ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 9: (0x402fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
10: (0x402fe4d5) [/usr/lib/libecore.so.1] + 0xc4d5
11: ecore_main_loop_begin + 0x30 (0x402fe879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x41392421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0xc2 (0x416b576b) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x376b
15: (0x40001a53) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1a53
16: __libc_start_main + 0x114 (0x4049485c) [/lib/libc.so.6] + 0x1785c
17: (0x40001e0c) [/opt/usr/apps/org.example.scorekeeperforgear/bin/scorekeeperforgear] + 0x1e0c
End of Call Stack

Package Information
Package Name: org.example.scorekeeperforgear
Package ID : org.example.scorekeeperforgear
Version: 1.0.0
Package Type: rpm
App Name: scorekeeperforgear
App ID: org.example.scorekeeperforgear
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1669), py(0)
06-25 22:21:53.500+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,702932)
06-25 22:21:53.505+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.505+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.505+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1693), py(0)
06-25 22:21:53.505+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,702932)
06-25 22:21:53.505+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1693), py(0)
06-25 22:21:53.515+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,758935)
06-25 22:21:53.515+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.515+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.520+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1713), py(0)
06-25 22:21:53.520+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,758935)
06-25 22:21:53.520+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1713), py(0)
06-25 22:21:53.530+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,802835)
06-25 22:21:53.530+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.530+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.530+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1729), py(0)
06-25 22:21:53.530+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,802835)
06-25 22:21:53.530+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1729), py(0)
06-25 22:21:53.540+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,844957)
06-25 22:21:53.545+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.545+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.545+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1744), py(0)
06-25 22:21:53.545+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,844957)
06-25 22:21:53.545+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1744), py(0)
06-25 22:21:53.560+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,897355)
06-25 22:21:53.565+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.565+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.565+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1763), py(0)
06-25 22:21:53.565+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,897355)
06-25 22:21:53.565+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1763), py(0)
06-25 22:21:53.580+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,934740)
06-25 22:21:53.580+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.580+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.580+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1776), py(0)
06-25 22:21:53.580+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,934740)
06-25 22:21:53.580+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1776), py(0)
06-25 22:21:53.595+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,958326)
06-25 22:21:53.595+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.595+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.595+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1784), py(0)
06-25 22:21:53.595+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,958326)
06-25 22:21:53.595+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1784), py(0)
06-25 22:21:53.615+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,986417)
06-25 22:21:53.620+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.620+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1795), py(0)
06-25 22:21:53.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,986417)
06-25 22:21:53.620+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1795), py(0)
06-25 22:21:53.630+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,995767)
06-25 22:21:53.630+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.630+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.635+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1798), py(0)
06-25 22:21:53.635+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,995767)
06-25 22:21:53.635+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_RENEW : px(1798), py(0)
06-25 22:21:53.650+0200 I/CAPI_WIDGET_APPLICATION(  988): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
06-25 22:21:53.650+0200 W/AUL     (  988): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(988) status(fg) type(widgetapp)
06-25 22:21:53.650+0200 I/CAPI_WIDGET_APPLICATION(  988): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
06-25 22:21:53.650+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] time(0,999994)
06-25 22:21:53.655+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
06-25 22:21:53.655+0200 I/ELM_RPANEL(  831): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
06-25 22:21:53.655+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_CANCEL : px(1800), py(0)
06-25 22:21:53.655+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] time(0,999994)
06-25 22:21:53.655+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] animation stop!!
06-25 22:21:53.660+0200 W/wnotib  (  831): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [1800][0][360][360]
06-25 22:21:53.660+0200 W/wnotib  (  831): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
06-25 22:21:53.660+0200 W/W_HOME  (  831): home_navigation.c: _anim_stop_cb(1316) > anim stop
06-25 22:21:53.660+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 22:21:53.660+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
06-25 22:21:53.660+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 22:21:53.660+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x46056818 : elm_scroller] detent_count(1)
06-25 22:21:53.660+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x46056818 : elm_scroller] pagenumber_v(0), pagenumber_h(5)
06-25 22:21:53.660+0200 I/efl-extension(  831): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x46056818 : elm_scroller] CurrentPage(5)
06-25 22:21:53.660+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x46056818 : elm_scroller] ECORE_CALLBACK_CANCEL : px(1800), py(0)
06-25 22:21:53.670+0200 W/WATCH_CORE(  961): appcore-watch.c: __widget_pause(1113) > widget_pause
06-25 22:21:53.670+0200 W/AUL     (  961): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.watchface.TacticalSentry) pid(961) status(bg) type(watchapp)
06-25 22:21:53.680+0200 E/watchface-app(  961): watchface.cpp: OnAppPause(717) > 
06-25 22:21:53.785+0200 E/W_HOME  (  831): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
06-25 22:21:53.795+0200 W/W_HOME  (  831): event_manager.c: _home_scroll_cb(585) > scroll,will,done
06-25 22:21:53.795+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:53.795+0200 W/W_HOME  (  831): event_manager.c: _home_scroll_cb(585) > scroll,done
06-25 22:21:53.795+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:54.050+0200 E/EFL     (  831): ecore_x<831> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=10288275 button=1
06-25 22:21:54.050+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.055+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 22:21:54.065+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.065+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:54.070+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.070+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:54.080+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.080+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:54.080+0200 E/EFL     (  988): evas_main<988> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 22:21:54.080+0200 E/EFL     (  988): evas_main<988> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 22:21:54.080+0200 E/EFL     (  988): evas_main<988> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 22:21:54.090+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.090+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:54.115+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.115+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:54.125+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.125+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:54.135+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.135+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:54.145+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.145+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:54.145+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4292 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] add hold animator
06-25 22:21:54.155+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:3868 _elm_scroll_hold_animator() [0x46056818 : elm_scroller] direction_x(0), direction_y(0)
06-25 22:21:54.155+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:3889 _elm_scroll_hold_animator() [0x46056818 : elm_scroller] move content x(1800), y(0)
06-25 22:21:54.155+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:54.155+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:54.170+0200 E/EFL     (  831): ecore_x<831> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=10288394 button=1
06-25 22:21:54.170+0200 W/W_HOME  (  831): home_navigation.c: _up_cb(1247) > up
06-25 22:21:54.170+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 22:21:54.170+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 22:21:54.185+0200 W/AUL     (  988): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-25 22:21:54.190+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
06-25 22:21:54.190+0200 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 988
06-25 22:21:54.190+0200 I/AUL_AMD (  507): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-25 22:21:54.215+0200 E/RESOURCED(  620): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 3
06-25 22:21:54.220+0200 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
06-25 22:21:54.220+0200 W/AUL_PAD ( 1331): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
06-25 22:21:54.220+0200 W/AUL_PAD ( 1331): launchpad.c: __send_result_to_caller(272) > Check app launching
06-25 22:21:54.220+0200 W/AUL_PAD ( 3754): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
06-25 22:21:54.225+0200 W/AUL_PAD ( 3754): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
06-25 22:21:54.225+0200 W/AUL_PAD ( 3754): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
06-25 22:21:54.225+0200 W/AUL_PAD ( 3754): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.scorekeeperforgear)
06-25 22:21:54.275+0200 I/efl-extension( 3754): efl_extension.c: eext_mod_init(40) > Init
06-25 22:21:54.280+0200 I/UXT     ( 3754): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-25 22:21:54.295+0200 W/AUL_PAD ( 3754): launchpad_loader.c: main(690) > [candidate] dlsym
06-25 22:21:54.295+0200 W/AUL_PAD ( 3754): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
06-25 22:21:54.310+0200 I/CAPI_APPFW_APPLICATION( 3754): app_main.c: ui_app_main(704) > app_efl_main
06-25 22:21:54.315+0200 I/CAPI_APPFW_APPLICATION( 3754): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
06-25 22:21:54.320+0200 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(3754) type(uiapp) bg(2)
06-25 22:21:54.320+0200 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (3754) was created
06-25 22:21:54.325+0200 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-25 22:21:54.325+0200 W/AUL     (  988): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3754)
06-25 22:21:54.325+0200 E/APP_SHORTCUT_WIDGET(  988): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
06-25 22:21:54.355+0200 W/STARTER (  742): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [3754]
06-25 22:21:54.470+0200 I/efl-extension( 3754): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1242) > Put the surface[0x41802598]'s widget[0x417fb948] to elm_conformant widget[0x45406b48]
06-25 22:21:54.475+0200 I/efl-extension( 3754): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
06-25 22:21:54.480+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
06-25 22:21:54.490+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
06-25 22:21:54.525+0200 I/efl-extension( 3754): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
06-25 22:21:54.525+0200 I/efl-extension( 3754): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
06-25 22:21:54.525+0200 I/efl-extension( 3754): efl_extension_rotary.c: _init_Xi2_system(314) > In
06-25 22:21:54.525+0200 I/efl-extension( 3754): efl_extension_rotary.c: _init_Xi2_system(375) > Done
06-25 22:21:54.525+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
06-25 22:21:54.525+0200 I/efl-extension( 3754): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x417fcc60, elm_layout, _activated_obj : 0x0, activated : 1
06-25 22:21:54.525+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:54.545+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:54.545+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:54.545+0200 E/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:54.545+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:54.550+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:54.550+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:54.550+0200 E/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:54.550+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:54.555+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:54.555+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:54.555+0200 E/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:54.555+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:54.560+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:54.560+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:54.560+0200 E/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:54.560+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:54.565+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:54.565+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:54.565+0200 E/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:54.565+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:54.570+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:54.570+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:54.570+0200 E/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:54.570+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:54.575+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:54.575+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:54.575+0200 E/efl-extension( 3754): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:54.575+0200 E/EFL     ( 3754): elementary<3754> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
06-25 22:21:54.585+0200 E/EFL     ( 3754): elementary<3754> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4543c720) will be pushed
06-25 22:21:54.595+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
06-25 22:21:54.605+0200 I/efl-extension( 3754): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
06-25 22:21:54.615+0200 I/APP_CORE( 3754): appcore-efl.c: __do_app(453) > [APP 3754] Event: RESET State: CREATED
06-25 22:21:54.615+0200 I/CAPI_APPFW_APPLICATION( 3754): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-25 22:21:54.635+0200 W/W_HOME  (  831): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
06-25 22:21:54.635+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:54.635+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:54.635+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:54.635+0200 W/W_HOME  (  831): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
06-25 22:21:54.635+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 22:21:54.635+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 22:21:54.640+0200 I/APP_CORE( 3754): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-25 22:21:54.640+0200 I/APP_CORE( 3754): appcore-efl.c: __do_app(524) > [APP 3754] Initial Launching, call the resume_cb
06-25 22:21:54.640+0200 I/CAPI_APPFW_APPLICATION( 3754): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-25 22:21:54.670+0200 W/W_HOME  (  831): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-25 22:21:54.695+0200 I/MALI    (  831): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ecf0e8] swap changed from sync to async
06-25 22:21:55.120+0200 W/PROCESSMGR(  469): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
06-25 22:21:55.125+0200 W/WATCH_CORE(  961): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
06-25 22:21:55.125+0200 I/WATCH_CORE(  961): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
06-25 22:21:55.125+0200 I/CAPI_WATCH_APPLICATION(  961): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-25 22:21:55.125+0200 E/watchface-app(  961): watchface.cpp: OnAppTimeTick(744) > 
06-25 22:21:55.125+0200 I/watchface-app(  961): watchface.cpp: OnAppTimeTick(756) > set force update!!
06-25 22:21:55.125+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
06-25 22:21:55.125+0200 I/watchface-viewer(  961): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 280x63
06-25 22:21:55.125+0200 I/watchface-viewer(  961): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
06-25 22:21:55.130+0200 W/W_HOME  (  831): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
06-25 22:21:55.130+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:55.130+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:55.135+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:55.135+0200 W/W_HOME  (  831): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
06-25 22:21:55.135+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 22:21:55.135+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 22:21:55.170+0200 E/EFL     (  469): ecore_x<469> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2800003 time=10289376
06-25 22:21:55.170+0200 E/EFL     (  831): ecore_x<831> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=10289376
06-25 22:21:55.170+0200 E/EFL     (  469): ecore_x<469> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=10289376
06-25 22:21:55.325+0200 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-25 22:21:55.325+0200 W/AUL_AMD (  507): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
06-25 22:21:55.360+0200 W/CRASH_MANAGER( 3845): worker.c: worker_job(1205) > 110375473636f1498422114
06-25 22:21:55.430+0200 W/AUL_PAD ( 1331): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 3754 pgid = 3754
06-25 22:21:55.430+0200 W/AUL_PAD ( 1331): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
06-25 22:21:55.455+0200 E/SECURITY_EXTENSION_SERVER(  477): security_extension_system.c: __read_proc(55) > file open error : 2
06-25 22:21:55.455+0200 E/SECURITY_EXTENSION_SERVER(  477): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
06-25 22:21:55.455+0200 E/SECURITY_EXTENSION_SERVER(  477): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(3754), proc(0)
06-25 22:21:55.455+0200 E/AUL     ( 1460): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
06-25 22:21:55.455+0200 E/CAPI_APPFW_APP_MANAGER( 1460): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
06-25 22:21:55.455+0200 E/SECURITY_EXTENSION_SERVER(  477): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
06-25 22:21:55.495+0200 W/AUL_PAD ( 1331): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
06-25 22:21:55.495+0200 I/AUL_AMD (  507): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3754
06-25 22:21:55.500+0200 W/AUL     (  507): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3754)
06-25 22:21:55.525+0200 E/SECURITY_EXTENSION_SERVER(  477): security_extension_system.c: __read_proc(55) > file open error : 2
06-25 22:21:55.525+0200 E/SECURITY_EXTENSION_SERVER(  477): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
06-25 22:21:55.525+0200 E/SECURITY_EXTENSION_SERVER(  477): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(3754), proc(0)
06-25 22:21:55.525+0200 E/SECURITY_EXTENSION_SERVER(  477): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
06-25 22:21:55.525+0200 E/AUL     ( 1326): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
06-25 22:21:55.525+0200 E/CAPI_APPFW_APP_MANAGER( 1326): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
06-25 22:21:55.645+0200 I/MALI    (  831): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ecf0e8] swap changed from async to sync
06-25 22:21:55.800+0200 I/AUL_PAD ( 3847): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
06-25 22:21:55.900+0200 E/EFL     (  831): ecore_x<831> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=10290125 button=1
06-25 22:21:55.905+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:55.905+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 22:21:55.910+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:55.910+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:55.920+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:55.920+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:55.930+0200 E/EFL     (  988): evas_main<988> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 22:21:55.930+0200 E/EFL     (  988): evas_main<988> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 22:21:55.930+0200 E/EFL     (  988): evas_main<988> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
06-25 22:21:55.950+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:55.950+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:55.955+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:55.955+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:55.975+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] mouse move
06-25 22:21:55.975+0200 E/EFL     (  831): elementary<831> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x46056818 : elm_scroller] hold(0), freeze(0)
06-25 22:21:55.985+0200 E/EFL     (  831): ecore_x<831> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=10290213 button=1
06-25 22:21:55.990+0200 W/W_HOME  (  831): home_navigation.c: _up_cb(1247) > up
06-25 22:21:55.990+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_del(822) > delete timer
06-25 22:21:55.990+0200 W/W_HOME  (  831): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
06-25 22:21:56.005+0200 W/AUL     (  988): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.scorekeeperforgear)
06-25 22:21:56.005+0200 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
06-25 22:21:56.010+0200 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 988
06-25 22:21:56.010+0200 I/AUL_AMD (  507): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-25 22:21:56.025+0200 E/RESOURCED(  620): block.c: block_prelaunch_state(138) > insert data org.example.scorekeeperforgear, table num : 3
06-25 22:21:56.030+0200 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
06-25 22:21:56.030+0200 W/AUL_PAD ( 1331): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
06-25 22:21:56.030+0200 W/AUL_PAD ( 1331): launchpad.c: __send_result_to_caller(272) > Check app launching
06-25 22:21:56.030+0200 W/AUL_PAD ( 3847): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
06-25 22:21:56.035+0200 W/AUL_PAD ( 3847): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
06-25 22:21:56.035+0200 W/AUL_PAD ( 3847): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
06-25 22:21:56.035+0200 W/AUL_PAD ( 3847): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.scorekeeperforgear)
06-25 22:21:56.080+0200 I/efl-extension( 3847): efl_extension.c: eext_mod_init(40) > Init
06-25 22:21:56.085+0200 I/UXT     ( 3847): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-25 22:21:56.100+0200 W/AUL_PAD ( 3847): launchpad_loader.c: main(690) > [candidate] dlsym
06-25 22:21:56.100+0200 W/AUL_PAD ( 3847): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.scorekeeperforgear)
06-25 22:21:56.110+0200 I/CAPI_APPFW_APPLICATION( 3847): app_main.c: ui_app_main(704) > app_efl_main
06-25 22:21:56.115+0200 I/CAPI_APPFW_APPLICATION( 3847): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
06-25 22:21:56.130+0200 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.scorekeeperforgear) pid(3847) type(uiapp) bg(2)
06-25 22:21:56.130+0200 W/AUL     (  988): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3847)
06-25 22:21:56.130+0200 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (3847) was created
06-25 22:21:56.130+0200 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-25 22:21:56.135+0200 E/APP_SHORTCUT_WIDGET(  988): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
06-25 22:21:56.160+0200 W/STARTER (  742): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [3847]
06-25 22:21:56.315+0200 I/efl-extension( 3847): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1242) > Put the surface[0x437f7910]'s widget[0x43804898] to elm_conformant widget[0x4187ed68]
06-25 22:21:56.320+0200 I/efl-extension( 3847): efl_extension_circle_surface.c: _eext_circle_surface_show_cb(740) > Surface will be initialized!
06-25 22:21:56.320+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_add(1990) > called!!
06-25 22:21:56.340+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: _eext_rotary_selector_data_init(586) > rsd is initialized!!
06-25 22:21:56.370+0200 I/efl-extension( 3847): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
06-25 22:21:56.370+0200 I/efl-extension( 3847): efl_extension_rotary.c: eext_rotary_event_handler_add(77) > init_count: 0
06-25 22:21:56.370+0200 I/efl-extension( 3847): efl_extension_rotary.c: _init_Xi2_system(314) > In
06-25 22:21:56.370+0200 I/efl-extension( 3847): efl_extension_rotary.c: _init_Xi2_system(375) > Done
06-25 22:21:56.370+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: _event_area_callback_add(500) > called!!
06-25 22:21:56.375+0200 I/efl-extension( 3847): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x43805bb0, elm_layout, _activated_obj : 0x0, activated : 1
06-25 22:21:56.375+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:56.390+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:56.390+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:56.390+0200 E/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:56.390+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:56.395+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:56.395+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:56.395+0200 E/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:56.395+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:56.405+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:56.405+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:56.405+0200 E/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:56.405+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:56.405+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:56.410+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:56.410+0200 E/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:56.410+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:56.410+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:56.410+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:56.410+0200 E/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:56.410+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:56.415+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:56.415+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:56.415+0200 E/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:56.415+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(2080) > called!!
06-25 22:21:56.420+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2453) > called!!
06-25 22:21:56.420+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2320) > called!!
06-25 22:21:56.420+0200 E/efl-extension( 3847): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_color_set(2759) > Not supported part name!!
06-25 22:21:56.430+0200 E/EFL     ( 3847): elementary<3847> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
06-25 22:21:56.435+0200 E/EFL     ( 3847): elementary<3847> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x4649d280) will be pushed
06-25 22:21:56.450+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: _rotary_selector_show_cb(805) > called!!
06-25 22:21:56.455+0200 I/efl-extension( 3847): efl_extension_rotary_selector.c: _rotary_selector_move_cb(776) > called!!
06-25 22:21:56.485+0200 W/W_HOME  (  831): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
06-25 22:21:56.485+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:56.485+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:56.485+0200 W/W_HOME  (  831): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-25 22:21:56.485+0200 W/W_HOME  (  831): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
06-25 22:21:56.485+0200 W/W_INDICATOR(  743): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
06-25 22:21:56.485+0200 W/W_INDICATOR(  743): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-25 22:21:56.490+0200 W/W_HOME  (  831): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
06-25 22:21:56.510+0200 I/APP_CORE( 3847): appcore-efl.c: __do_app(453) > [APP 3847] Event: RESET State: CREATED
06-25 22:21:56.510+0200 I/CAPI_APPFW_APPLICATION( 3847): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-25 22:21:56.520+0200 I/APP_CORE( 3847): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-25 22:21:56.520+0200 I/APP_CORE( 3847): appcore-efl.c: __do_app(524) > [APP 3847] Initial Launching, call the resume_cb
06-25 22:21:56.520+0200 I/CAPI_APPFW_APPLICATION( 3847): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-25 22:21:56.710+0200 W/CRASH_MANAGER( 3845): worker.c: worker_job(1205) > 110384773636f149842211
