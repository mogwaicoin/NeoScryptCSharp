using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NeoScryptTest
{
    [TestClass]
    public class BlockheaderHashTest
    {
        [TestMethod]
        public void MogwaicoinGenesisMainnet()
        {
            string version = "01000000";
            string prev_block = "0000000000000000000000000000000000000000000000000000000000000000";
            string merkle_root = "ced6de01d8d26ce7613669df2fc002d6f2138159744cf84d3c68d6245bb8989d"; 
            string timestamp = "b0f62f5b";
            string bits = "f0ff0f1e";
            string nonce = "a5060a00";

            string blockHeader = version + prev_block + merkle_root + timestamp + bits + nonce;
            byte[] toHash = Util.HexStr2Bytes(blockHeader);
            byte[] output = new byte[32];
            NeoScrypt.NeoScrypt.neoscrypt(toHash, ref output, 0x0);

            // getblockhash 0 -> 000006ba48cbdecd71bc411a3e0b609f1acab9806fc652040f247c8b86831d06
            Array.Reverse(output);
            Assert.AreEqual(Util.Bytes2HexStr(output),
                "000006ba48cbdecd71bc411a3e0b609f1acab9806fc652040f247c8b86831d06");
        }

        [TestMethod]
        public void MogwaicoinBlock100()
        {
            string version = "00000020";   
            string prev_block = "4e3f108d2a169631de3c9e89425a5762c9a5198ead7253b1d1f7e7de8f050000";
            string merkle_root = "831c14e682af55f2d4ab5384ef3bb9822d824fe5b03ea92634c0f83a57ffbb23";
            string timestamp = "f716315b";
            string bits = "ffff0f1e";
            string nonce = "91630000";

            string blockHeader = version + prev_block + merkle_root + timestamp + bits + nonce;
            byte[] toHash = Util.HexStr2Bytes(blockHeader);
            byte[] output = new byte[32];
            NeoScrypt.NeoScrypt.neoscrypt(toHash, ref output, 0x0);

            // getblockhash 100 -> 00000f7507d7ec543e61914078aec2ff1f97aa005855421746a9b1dad4b0e751
            Array.Reverse(output);
            Assert.AreEqual(Util.Bytes2HexStr(output),
                "00000f7507d7ec543e61914078aec2ff1f97aa005855421746a9b1dad4b0e751");
        }

        [TestMethod]
        public void MogwaicoinBlock22500()
        {
            string version = "00000020";
            string prev_block = "08cac86e68e2f192bf7c9ee3fe389be22ad04e89dddf6adb2eb7aa0900000000";
            string merkle_root = "7a141bd548bf0c7fb35ee10f0bbdce30e825c0ae6ed44d2732af487566b73d6b";
            string timestamp = "9b8d615b";
            string bits = "4c9a001d";
            string nonce = "40404263";

            string blockHeader = version + prev_block + merkle_root + timestamp + bits + nonce;
            byte[] toHash = Util.HexStr2Bytes(blockHeader);
            byte[] output = new byte[32];
            NeoScrypt.NeoScrypt.neoscrypt(toHash, ref output, 0x0);

            // getblockhash 22500 -> 000000007e47e29fc6f8010849c6d28f67718d37391cb30601ae3ccc90510f0a
            Array.Reverse(output);
            Assert.AreEqual(Util.Bytes2HexStr(output),
                "000000007e47e29fc6f8010849c6d28f67718d37391cb30601ae3ccc90510f0a");
        }

    }
}
