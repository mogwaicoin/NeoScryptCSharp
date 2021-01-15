# NeoScryptCSharp

**NeoScrypt C# Implementation**
*converted by darkfriend77 from Mogwaicoin Team*

https://github.com/ghostlander/NeoScrypt/tree/89c04c75a674974936c6579b42764d5370139d3d

If you enjoy using SubstrateNetApi consider supporting me at [buymeacoffee.com/darkfriend77](https://www.buymeacoffee.com/darkfriend77)

NeoScrypt
=========

NeoScrypt is a strong memory intensive key derivation function.

Compile time definitions:
 - -DNEOSCRYPT_SHA256 enables optional SHA-256 support (Scrypt compatibility);
 - -DNEOSCRYPT_BLAKE256 enables optional BLAKE-256 support;
 - -DNEOSCRYPT_OPT enables FastKDF performance optimisations;
 - -DNEOSCRYPT_ASM enables 32-bit and 64-bit assembly optimisations;
 - -DNEOSCRYPT_MINER_4WAY enables 4-way mining per thread (requires -DNEOSCRYPT_ASM).

There are also test vectors and benchmarks available.

Orginal source: https://github.com/ghostlander/NeoScrypt

- Copyright (c) 2009 Colin Percival, 2011 ArtForz
- Copyright (c) 2012 Andrew Moon (floodyberry)
- Copyright (c) 2012 Samuel Neves <sneves@dei.uc.pt>
- Copyright (c) 2014-2018 John Doering <ghostlander@phoenixcoin.org>
- All rights reserved.

Documentation
-------------

Refer to the following white paper for an introduction to NeoScrypt:
http://phoenixcoin.org/archive/neoscrypt_v1.pdf
