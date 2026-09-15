## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply4x4()
       push      rbx
       sub       rsp,0A0
       mov       rbx,rdx
       vmovdqu32 zmm0,[rcx+8]
       vmovdqu32 [rsp+60],zmm0
       vmovdqu32 zmm0,[rcx+48]
       vmovdqu32 [rsp+20],zmm0
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFEAFC6FDC8]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 87
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       vmovups   xmm0,[rdx]
       vmovups   xmm1,[rdx+10]
       vmovups   xmm2,[rdx+20]
       vmovups   xmm3,[rdx+30]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm16,[r8+20]
       vmovups   xmm17,[r8+30]
       vunpckhps xmm18,xmm0,xmm0
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm0
       vbroadcastss xmm19,xmm19
       vmovaps   xmm20,xmm0
       vbroadcastss xmm20,xmm20
       vmulps    xmm20,xmm20,xmm4
       vfmadd231ps xmm20,xmm19,xmm5
       vfmadd231ps xmm20,xmm18,xmm16
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm20,xmm0,xmm17
       vunpckhps xmm0,xmm1,xmm1
       vbroadcastss xmm0,xmm0
       vmovshdup xmm18,xmm1
       vbroadcastss xmm18,xmm18
       vmovaps   xmm19,xmm1
       vbroadcastss xmm19,xmm19
       vmulps    xmm19,xmm19,xmm4
       vfmadd231ps xmm19,xmm18,xmm5
       vfmadd231ps xmm19,xmm0,xmm16
       vshufps   xmm0,xmm1,xmm1,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm19,xmm0,xmm17
       vunpckhps xmm0,xmm2,xmm2
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm2
       vbroadcastss xmm1,xmm1
       vmovaps   xmm18,xmm2
       vbroadcastss xmm18,xmm18
       vmulps    xmm18,xmm18,xmm4
       vfmadd231ps xmm18,xmm1,xmm5
       vfmadd231ps xmm18,xmm0,xmm16
       vshufps   xmm0,xmm2,xmm2,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm18,xmm0,xmm17
       vunpckhps xmm0,xmm3,xmm3
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm3
       vbroadcastss xmm1,xmm1
       vmovaps   xmm2,xmm3
       vbroadcastss xmm2,xmm2
       vmulps    xmm2,xmm2,xmm4
       vfmadd213ps xmm5,xmm1,xmm2
       vfmadd213ps xmm16,xmm0,xmm5
       vshufps   xmm0,xmm3,xmm3,0FF
       vbroadcastss xmm0,xmm0
       vfmadd213ps xmm17,xmm0,xmm16
       vmovups   [rcx],xmm20
       vmovups   [rcx+10],xmm19
       vmovups   [rcx+20],xmm18
       vmovups   [rcx+30],xmm17
       mov       rax,rcx
       ret
; Total bytes of code 334
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Add4x4()
       push      rbx
       sub       rsp,0A0
       mov       rbx,rdx
       vmovdqu32 zmm0,[rcx+8]
       vmovdqu32 [rsp+60],zmm0
       vmovdqu32 zmm0,[rcx+48]
       vmovdqu32 [rsp+20],zmm0
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFEAFC8FDC8]; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 87
```
```assembly
; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       vmovups   xmm0,[rdx]
       vmovups   xmm1,[rdx+10]
       vmovups   xmm2,[rdx+20]
       vmovups   xmm3,[rdx+30]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm16,[r8+20]
       vmovups   xmm17,[r8+30]
       vaddps    xmm0,xmm0,xmm4
       vaddps    xmm1,xmm1,xmm5
       vaddps    xmm2,xmm2,xmm16
       vaddps    xmm3,xmm3,xmm17
       vmovups   [rcx],xmm0
       vmovups   [rcx+10],xmm1
       vmovups   [rcx+20],xmm2
       vmovups   [rcx+30],xmm3
       mov       rax,rcx
       ret
; Total bytes of code 87
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply3x2()
       push      rbx
       sub       rsp,50
       mov       rbx,rdx
       vmovdqu   xmm0,xmmword ptr [rcx+88]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rdx,[rcx+98]
       mov       [rsp+48],rdx
       vmovdqu32 xmm0,[rcx+0A0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       rdx,[rcx+0B0]
       mov       [rsp+30],rdx
       lea       rdx,[rsp+38]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFEAFC9FDC8]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       ret
; Total bytes of code 87
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       vmovss    xmm0,dword ptr [rdx]
       vmovss    xmm1,dword ptr [rdx+4]
       vmovss    xmm2,dword ptr [rdx+8]
       vmovss    xmm3,dword ptr [rdx+0C]
       vmovss    xmm4,dword ptr [rdx+10]
       vmovss    xmm5,dword ptr [rdx+14]
       vmovss    xmm16,dword ptr [r8]
       vmovss    xmm17,dword ptr [r8+4]
       vmovss    xmm18,dword ptr [r8+8]
       vmovss    xmm19,dword ptr [r8+0C]
       vmovss    xmm20,dword ptr [r8+10]
       vmovss    xmm21,dword ptr [r8+14]
       vmulss    xmm22,xmm0,xmm16
       vmulss    xmm23,xmm1,xmm18
       vaddss    xmm22,xmm22,xmm23
       vmulss    xmm0,xmm0,xmm17
       vmulss    xmm1,xmm1,xmm19
       vaddss    xmm0,xmm0,xmm1
       vinsertps xmm0,xmm22,xmm0,1C
       vmulss    xmm1,xmm2,xmm16
       vmulss    xmm22,xmm3,xmm18
       vaddss    xmm1,xmm1,xmm22
       vmulss    xmm2,xmm2,xmm17
       vmulss    xmm3,xmm3,xmm19
       vaddss    xmm2,xmm2,xmm3
       vinsertps xmm1,xmm1,xmm2,1C
       vmulss    xmm2,xmm4,xmm16
       vmulss    xmm3,xmm5,xmm18
       vaddss    xmm2,xmm2,xmm3
       vaddss    xmm2,xmm2,xmm20
       vmulss    xmm3,xmm4,xmm17
       vmulss    xmm4,xmm5,xmm19
       vaddss    xmm3,xmm3,xmm4
       vaddss    xmm3,xmm3,xmm21
       vinsertps xmm2,xmm2,xmm3,1C
       vmovsd    qword ptr [rcx],xmm0
       vmovsd    qword ptr [rcx+8],xmm1
       vmovsd    qword ptr [rcx+10],xmm2
       mov       rax,rcx
       ret
; Total bytes of code 219
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply4x4()
       push      rbx
       sub       rsp,0A0
       vzeroupper
       mov       rbx,rdx
       vmovdqu32 zmm0,[rcx+8]
       vmovdqu32 [rsp+60],zmm0
       vmovdqu32 zmm0,[rcx+48]
       vmovdqu32 [rsp+20],zmm0
       mov       rcx,rbx
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       call      qword ptr [7FFE6CD96970]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 90
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       push      rbx
       sub       rsp,0E0
       vzeroupper
       mov       rbx,rcx
       vmovdqu32 zmm0,[rdx]
       vmovdqu32 [rsp+0A0],zmm0
       vmovdqu32 zmm0,[r8]
       vmovdqu32 [rsp+60],zmm0
       lea       rcx,[rsp+20]
       lea       rdx,[rsp+0A0]
       lea       r8,[rsp+60]
       call      qword ptr [7FFE6CCCDCB0]; System.Numerics.Matrix4x4+Impl.op_Multiply(Impl ByRef, Impl ByRef)
       vmovdqu32 zmm0,[rsp+20]
       vmovdqu32 [rbx],zmm0
       mov       rax,rbx
       vzeroupper
       add       rsp,0E0
       pop       rbx
       ret
; Total bytes of code 104
```
```assembly
; System.Numerics.Matrix4x4+Impl.op_Multiply(Impl ByRef, Impl ByRef)
       vzeroupper
       vmovups   xmm0,[r8]
       vbroadcastss xmm1,dword ptr [rdx]
       vmulps    xmm1,xmm0,xmm1
       vmovups   xmm2,[r8+10]
       vbroadcastss xmm3,dword ptr [rdx+4]
       vmulps    xmm3,xmm2,xmm3
       vaddps    xmm1,xmm1,xmm3
       vmovups   xmm3,[r8+20]
       vbroadcastss xmm4,dword ptr [rdx+8]
       vmulps    xmm4,xmm3,xmm4
       vaddps    xmm1,xmm1,xmm4
       vmovups   xmm4,[r8+30]
       vbroadcastss xmm5,dword ptr [rdx+0C]
       vmulps    xmm5,xmm4,xmm5
       vaddps    xmm1,xmm1,xmm5
       vbroadcastss xmm5,dword ptr [rdx+10]
       vmulps    xmm5,xmm0,xmm5
       vbroadcastss xmm16,dword ptr [rdx+14]
       vmulps    xmm16,xmm2,xmm16
       vaddps    xmm5,xmm5,xmm16
       vbroadcastss xmm16,dword ptr [rdx+18]
       vmulps    xmm16,xmm3,xmm16
       vaddps    xmm5,xmm5,xmm16
       vbroadcastss xmm16,dword ptr [rdx+1C]
       vmulps    xmm16,xmm4,xmm16
       vaddps    xmm5,xmm5,xmm16
       vbroadcastss xmm16,dword ptr [rdx+20]
       vmulps    xmm16,xmm0,xmm16
       vbroadcastss xmm17,dword ptr [rdx+24]
       vmulps    xmm17,xmm2,xmm17
       vaddps    xmm16,xmm16,xmm17
       vbroadcastss xmm17,dword ptr [rdx+28]
       vmulps    xmm17,xmm3,xmm17
       vaddps    xmm16,xmm16,xmm17
       vbroadcastss xmm17,dword ptr [rdx+2C]
       vmulps    xmm17,xmm4,xmm17
       vaddps    xmm16,xmm16,xmm17
       vbroadcastss xmm17,dword ptr [rdx+30]
       vmulps    xmm0,xmm0,xmm17
       vbroadcastss xmm17,dword ptr [rdx+34]
       vmulps    xmm2,xmm2,xmm17
       vaddps    xmm0,xmm0,xmm2
       vbroadcastss xmm2,dword ptr [rdx+38]
       vmulps    xmm2,xmm3,xmm2
       vaddps    xmm0,xmm0,xmm2
       vbroadcastss xmm2,dword ptr [rdx+3C]
       vmulps    xmm2,xmm4,xmm2
       vaddps    xmm0,xmm0,xmm2
       vmovups   [rcx],xmm1
       vmovups   [rcx+10],xmm5
       vmovups   [rcx+20],xmm16
       vmovups   [rcx+30],xmm0
       mov       rax,rcx
       ret
; Total bytes of code 297
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Add4x4()
       push      rbx
       sub       rsp,0A0
       vzeroupper
       mov       rbx,rdx
       vmovdqu32 zmm0,[rcx+8]
       vmovdqu32 [rsp+60],zmm0
       vmovdqu32 zmm0,[rcx+48]
       vmovdqu32 [rsp+20],zmm0
       mov       rcx,rbx
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       call      qword ptr [7FFE6CD869A0]; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 90
```
```assembly
; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       sub       rsp,48
       vzeroupper
       vmovdqu32 zmm0,[rdx]
       vmovdqu32 [rsp+8],zmm0
       vmovups   xmm0,[r8]
       vmovups   xmm1,[r8+10]
       vmovups   xmm2,[r8+20]
       vmovups   xmm3,[r8+30]
       lea       rax,[rsp+8]
       vaddps    xmm0,xmm0,[rax]
       vaddps    xmm1,xmm1,[rax+10]
       vaddps    xmm2,xmm2,[rax+20]
       vaddps    xmm3,xmm3,[rax+30]
       vmovups   [rcx],xmm0
       vmovups   [rcx+10],xmm1
       vmovups   [rcx+20],xmm2
       vmovups   [rcx+30],xmm3
       mov       rax,rcx
       vzeroupper
       add       rsp,48
       ret
; Total bytes of code 101
```

## .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply3x2()
       push      rbx
       sub       rsp,50
       vzeroupper
       mov       rbx,rdx
       vmovdqu   xmm0,xmmword ptr [rcx+88]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rdx,[rcx+98]
       mov       [rsp+48],rdx
       vmovdqu   xmm0,xmmword ptr [rcx+0A0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       rdx,[rcx+0B0]
       mov       [rsp+30],rdx
       mov       rcx,rbx
       lea       rdx,[rsp+38]
       lea       r8,[rsp+20]
       call      qword ptr [7FFE6CD96178]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       ret
; Total bytes of code 91
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       sub       rsp,18
       vzeroupper
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rsp],xmm0
       mov       rax,[rdx+10]
       mov       [rsp+10],rax
       vmovss    xmm0,dword ptr [r8]
       vmovss    xmm1,dword ptr [r8+4]
       vmovss    xmm2,dword ptr [r8+8]
       vmovss    xmm3,dword ptr [r8+0C]
       vmovss    xmm4,dword ptr [r8+10]
       vmovss    xmm5,dword ptr [r8+14]
       lea       rax,[rsp]
       vmovss    xmm16,dword ptr [rax]
       vmulss    xmm17,xmm16,xmm0
       vmovss    xmm18,dword ptr [rax+4]
       vmulss    xmm19,xmm18,xmm2
       vaddss    xmm17,xmm17,xmm19
       vmulss    xmm16,xmm16,xmm1
       vmulss    xmm18,xmm18,xmm3
       vaddss    xmm16,xmm16,xmm18
       vinsertps xmm16,xmm17,xmm16,1C
       vmovss    xmm17,dword ptr [rax+8]
       vmulss    xmm18,xmm17,xmm0
       vmovss    xmm19,dword ptr [rax+0C]
       vmulss    xmm20,xmm19,xmm2
       vaddss    xmm18,xmm18,xmm20
       vmulss    xmm17,xmm17,xmm1
       vmulss    xmm19,xmm19,xmm3
       vaddss    xmm17,xmm17,xmm19
       vinsertps xmm17,xmm18,xmm17,1C
       vmovss    xmm18,dword ptr [rax+10]
       vmulss    xmm0,xmm18,xmm0
       vmovss    xmm19,dword ptr [rax+14]
       vmulss    xmm2,xmm19,xmm2
       vaddss    xmm0,xmm0,xmm2
       vaddss    xmm0,xmm0,xmm4
       vmulss    xmm1,xmm18,xmm1
       vmulss    xmm2,xmm19,xmm3
       vaddss    xmm1,xmm1,xmm2
       vaddss    xmm1,xmm1,xmm5
       vinsertps xmm0,xmm0,xmm1,1C
       vmovsd    qword ptr [rcx],xmm16
       vmovsd    qword ptr [rcx+8],xmm17
       vmovsd    qword ptr [rcx+10],xmm0
       mov       rax,rcx
       add       rsp,18
       ret
; Total bytes of code 263
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply4x4()
       push      rbx
       sub       rsp,0A0
       mov       rbx,rdx
       vmovdqu32 zmm0,[rcx+8]
       vmovdqu32 [rsp+60],zmm0
       vmovdqu32 zmm0,[rcx+48]
       vmovdqu32 [rsp+20],zmm0
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFE6CC7ED90]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 87
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       vmovups   xmm0,[rdx]
       vmovups   xmm1,[rdx+10]
       vmovups   xmm2,[rdx+20]
       vmovups   xmm3,[rdx+30]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm16,[r8+20]
       vmovups   xmm17,[r8+30]
       vunpckhps xmm18,xmm0,xmm0
       vbroadcastss xmm18,xmm18
       vmovshdup xmm19,xmm0
       vbroadcastss xmm19,xmm19
       vmovaps   xmm20,xmm0
       vbroadcastss xmm20,xmm20
       vmulps    xmm20,xmm20,xmm4
       vfmadd231ps xmm20,xmm19,xmm5
       vfmadd231ps xmm20,xmm18,xmm16
       vshufps   xmm0,xmm0,xmm0,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm20,xmm0,xmm17
       vunpckhps xmm0,xmm1,xmm1
       vbroadcastss xmm0,xmm0
       vmovshdup xmm18,xmm1
       vbroadcastss xmm18,xmm18
       vmovaps   xmm19,xmm1
       vbroadcastss xmm19,xmm19
       vmulps    xmm19,xmm19,xmm4
       vfmadd231ps xmm19,xmm18,xmm5
       vfmadd231ps xmm19,xmm0,xmm16
       vshufps   xmm0,xmm1,xmm1,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm19,xmm0,xmm17
       vunpckhps xmm0,xmm2,xmm2
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm2
       vbroadcastss xmm1,xmm1
       vmovaps   xmm18,xmm2
       vbroadcastss xmm18,xmm18
       vmulps    xmm18,xmm18,xmm4
       vfmadd231ps xmm18,xmm1,xmm5
       vfmadd231ps xmm18,xmm0,xmm16
       vshufps   xmm0,xmm2,xmm2,0FF
       vbroadcastss xmm0,xmm0
       vfmadd231ps xmm18,xmm0,xmm17
       vunpckhps xmm0,xmm3,xmm3
       vbroadcastss xmm0,xmm0
       vmovshdup xmm1,xmm3
       vbroadcastss xmm1,xmm1
       vmovaps   xmm2,xmm3
       vbroadcastss xmm2,xmm2
       vmulps    xmm2,xmm2,xmm4
       vfmadd213ps xmm5,xmm1,xmm2
       vfmadd213ps xmm16,xmm0,xmm5
       vshufps   xmm0,xmm3,xmm3,0FF
       vbroadcastss xmm0,xmm0
       vfmadd213ps xmm17,xmm0,xmm16
       vmovups   [rcx],xmm20
       vmovups   [rcx+10],xmm19
       vmovups   [rcx+20],xmm18
       vmovups   [rcx+30],xmm17
       mov       rax,rcx
       ret
; Total bytes of code 334
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Add4x4()
       push      rbx
       sub       rsp,0A0
       mov       rbx,rdx
       vmovdqu32 zmm0,[rcx+8]
       vmovdqu32 [rsp+60],zmm0
       vmovdqu32 zmm0,[rcx+48]
       vmovdqu32 [rsp+20],zmm0
       lea       rdx,[rsp+60]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFE6CC5ECB8]; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       mov       rax,rbx
       vzeroupper
       add       rsp,0A0
       pop       rbx
       ret
; Total bytes of code 87
```
```assembly
; LegacyProof.Subjects.Add(System.Numerics.Matrix4x4, System.Numerics.Matrix4x4)
       vmovups   xmm0,[rdx]
       vmovups   xmm1,[rdx+10]
       vmovups   xmm2,[rdx+20]
       vmovups   xmm3,[rdx+30]
       vmovups   xmm4,[r8]
       vmovups   xmm5,[r8+10]
       vmovups   xmm16,[r8+20]
       vmovups   xmm17,[r8+30]
       vaddps    xmm0,xmm0,xmm4
       vaddps    xmm1,xmm1,xmm5
       vaddps    xmm2,xmm2,xmm16
       vaddps    xmm3,xmm3,xmm17
       vmovups   [rcx],xmm0
       vmovups   [rcx+10],xmm1
       vmovups   [rcx+20],xmm2
       vmovups   [rcx+30],xmm3
       mov       rax,rcx
       ret
; Total bytes of code 87
```

## .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; LegacyProof.Benchmarks.MatrixBench.Multiply3x2()
       push      rbx
       sub       rsp,50
       mov       rbx,rdx
       vmovdqu   xmm0,xmmword ptr [rcx+88]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       rdx,[rcx+98]
       mov       [rsp+48],rdx
       vmovdqu   xmm0,xmmword ptr [rcx+0A0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       mov       rdx,[rcx+0B0]
       mov       [rsp+30],rdx
       lea       rdx,[rsp+38]
       lea       r8,[rsp+20]
       mov       rcx,rbx
       call      qword ptr [7FFE6CC7ECB8]; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       ret
; Total bytes of code 88
```
```assembly
; LegacyProof.Subjects.Multiply(System.Numerics.Matrix3x2, System.Numerics.Matrix3x2)
       vmovss    xmm0,dword ptr [rdx]
       vmovss    xmm1,dword ptr [rdx+4]
       vmovss    xmm2,dword ptr [rdx+8]
       vmovss    xmm3,dword ptr [rdx+0C]
       vmovss    xmm4,dword ptr [rdx+10]
       vmovss    xmm5,dword ptr [rdx+14]
       vmovss    xmm16,dword ptr [r8]
       vmovss    xmm17,dword ptr [r8+4]
       vmovss    xmm18,dword ptr [r8+8]
       vmovss    xmm19,dword ptr [r8+0C]
       vmovss    xmm20,dword ptr [r8+10]
       vmovss    xmm21,dword ptr [r8+14]
       vmulss    xmm22,xmm0,xmm16
       vmulss    xmm23,xmm1,xmm18
       vaddss    xmm22,xmm22,xmm23
       vmulss    xmm0,xmm0,xmm17
       vmulss    xmm1,xmm1,xmm19
       vaddss    xmm0,xmm0,xmm1
       vinsertps xmm0,xmm22,xmm0,1C
       vmulss    xmm1,xmm2,xmm16
       vmulss    xmm22,xmm3,xmm18
       vaddss    xmm1,xmm1,xmm22
       vmulss    xmm2,xmm2,xmm17
       vmulss    xmm3,xmm3,xmm19
       vaddss    xmm2,xmm2,xmm3
       vinsertps xmm1,xmm1,xmm2,1C
       vmulss    xmm2,xmm4,xmm16
       vmulss    xmm3,xmm5,xmm18
       vaddss    xmm2,xmm2,xmm3
       vaddss    xmm2,xmm2,xmm20
       vmulss    xmm3,xmm4,xmm17
       vmulss    xmm4,xmm5,xmm19
       vaddss    xmm3,xmm3,xmm4
       vaddss    xmm3,xmm3,xmm21
       vinsertps xmm2,xmm2,xmm3,1C
       vmovsd    qword ptr [rcx],xmm0
       vmovsd    qword ptr [rcx+8],xmm1
       vmovsd    qword ptr [rcx+10],xmm2
       mov       rax,rcx
       ret
; Total bytes of code 219
```

