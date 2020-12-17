using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodesgraphtiles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Node> nodes = new List<Node>();
        for(int j =0; j < 9; j++)
        {
            for(int i = 0; i < 14; i++)
            {
                Node node = new Node(i, j);
                nodes.Add(node);
            }
        }

        Node node00 = new Node(0,0);
        Node node10 = new Node(1,0);
        Node node20 = new Node(2,0);
        Node node30 = new Node(3,0);
        Node node40 = new Node(4,0);
        Node node50 = new Node(5,0);
        Node node60 = new Node(6,0);
        Node node70 = new Node(7,0);
        Node node80 = new Node(8,0);
        Node node90 = new Node(9,0);
        Node node100 = new Node(10,0);
        Node node110 = new Node(11,0);
        Node node120 = new Node(12,0);
        Node node130 = new Node(13,0);

        Node node01 = new Node(0, 1);
        Node node11 = new Node(1, 1);
        Node node21 = new Node(2, 1);
        Node node31 = new Node(3, 1);
        Node node41 = new Node(4, 1);
        Node node51 = new Node(5, 1);
        Node node61 = new Node(6, 1);
        Node node71 = new Node(7, 1);
        Node node81 = new Node(8, 1);
        Node node91 = new Node(9, 1);
        Node node101 = new Node(10, 1);
        Node node111 = new Node(11, 1);
        Node node121 = new Node(12, 1);
        Node node131 = new Node(13, 1);

        Node node02 = new Node(0, 2);
        Node node12 = new Node(1, 2);
        Node node22 = new Node(2, 2);
        Node node32 = new Node(3, 2);
        Node node42 = new Node(4, 2);
        Node node52 = new Node(5, 2);
        Node node62 = new Node(6, 2);
        Node node72 = new Node(7, 2);
        Node node82 = new Node(8, 2);
        Node node92 = new Node(9, 2);
        Node node102 = new Node(10, 2);
        Node node112 = new Node(11, 2);
        Node node122 = new Node(12, 2);
        Node node132 = new Node(13, 2);

        Node node03 = new Node(0, 3);
        Node node13 = new Node(1, 3);
        Node node23 = new Node(2, 3);
        Node node33 = new Node(3, 3);
        Node node43 = new Node(4, 3);
        Node node53 = new Node(5, 3);
        Node node63 = new Node(6, 3);
        Node node73 = new Node(7, 3);
        Node node83 = new Node(8, 3);
        Node node93 = new Node(9, 3);
        Node node103 = new Node(10, 3);
        Node node113 = new Node(11, 3);
        Node node123 = new Node(12, 3);
        Node node133 = new Node(13, 3);

        Node node04 = new Node(0, 4);
        Node node14 = new Node(1, 4);
        Node node24 = new Node(2, 4);
        Node node34 = new Node(3, 4);
        Node node44 = new Node(4, 4);
        Node node54 = new Node(5, 4);
        Node node64 = new Node(6, 4);
        Node node74 = new Node(7, 4);
        Node node84 = new Node(8, 4);
        Node node94 = new Node(9, 4);
        Node node104 = new Node(10, 4);
        Node node114 = new Node(11, 4);
        Node node124 = new Node(12, 4);
        Node node134 = new Node(13, 4);    

        Node node05 = new Node(0, 5);
        Node node15 = new Node(1, 5);
        Node node25 = new Node(2, 5);
        Node node35 = new Node(3, 5);
        Node node45 = new Node(4, 5);
        Node node55 = new Node(5, 5);
        Node node65 = new Node(6, 5);
        Node node75 = new Node(7, 5);
        Node node85 = new Node(8, 5);
        Node node95 = new Node(9, 5);
        Node node105 = new Node(10, 5);
        Node node115 = new Node(11, 5);
        Node node125 = new Node(12, 5);
        Node node135 = new Node(13, 5);

        Node node06 = new Node(0, 6);
        Node node16 = new Node(1, 6);
        Node node26 = new Node(2, 6);
        Node node36 = new Node(3, 6);
        Node node46 = new Node(4, 6);
        Node node56 = new Node(5, 6);
        Node node66 = new Node(6, 6);
        Node node76 = new Node(7, 6);
        Node node86 = new Node(8, 6);
        Node node96 = new Node(9, 6);
        Node node106 = new Node(10, 6);
        Node node116 = new Node(11, 6);
        Node node126 = new Node(12, 6);
        Node node136 = new Node(13, 6);

        Node node07 = new Node(0, 7);
        Node node17 = new Node(1, 7);
        Node node27 = new Node(2, 7);
        Node node37 = new Node(3, 7);
        Node node47 = new Node(4, 7);
        Node node57 = new Node(5, 7);
        Node node67 = new Node(6, 7);
        Node node77 = new Node(7, 7);
        Node node87 = new Node(8, 7);
        Node node97 = new Node(9, 7);
        Node node107 = new Node(10, 7);
        Node node117 = new Node(11, 7);
        Node node127 = new Node(12, 7);
        Node node137 = new Node(13, 7);

        node00.children.Add(node01);
        node00.children.Add(node10);

        node01.children.Add(node00);
        node01.children.Add(node02);

        node02.children.Add(node01);
        node02.children.Add(node03);
        node02.children.Add(node12);

        node03.children.Add(node02);
        node03.children.Add(node04);

        node04.children.Add(node03);
        node04.children.Add(node05); 
        node04.children.Add(node14);

        node05.children.Add(node04);
        node05.children.Add(node06);
        node05.children.Add(node15);

        node06.children.Add(node05);
        node06.children.Add(node07);

        node07.children.Add(node06);
        node07.children.Add(node17);

        node10.children.Add(node00);
        node10.children.Add(node20);

        node12.children.Add(node02);
        node12.children.Add(node22);

        node13.children.Add(node14);
        node13.children.Add(node23);

        node14.children.Add(node04);
        node14.children.Add(node13);

        node15.children.Add(node05);
        node15.children.Add(node25);

        node17.children.Add(node07);
        node17.children.Add(node27);

        node20.children.Add(node10);
        node20.children.Add(node21);
        node20.children.Add(node30);

        node21.children.Add(node20);
        node21.children.Add(node22);

        node22.children.Add(node12);
        node22.children.Add(node21);

        node23.children.Add(node13);
        node23.children.Add(node24);

        node24.children.Add(node23);
        node24.children.Add(node34);

        node25.children.Add(node15);
        node25.children.Add(node26);

        node26.children.Add(node25);
        node26.children.Add(node27);

        node27.children.Add(node17);
        node27.children.Add(node26);
        node27.children.Add(node37);

        node30.children.Add(node20);
        node30.children.Add(node31);
        node30.children.Add(node40);

        node31.children.Add(node30);
        node31.children.Add(node41);

        node33.children.Add(node34);
        node33.children.Add(node43);

        node34.children.Add(node24);
        node34.children.Add(node33);
        node34.children.Add(node35);

        node35.children.Add(node34);
        node35.children.Add(node36);

        node36.children.Add(node35);
        node36.children.Add(node37);

        node37.children.Add(node27);
        node37.children.Add(node36);
        node37.children.Add(node47);

        node40.children.Add(node30);
        node40.children.Add(node50);

        node41.children.Add(node42);
        node41.children.Add(node31);

        node42.children.Add(node41);
        node42.children.Add(node52);

        node43.children.Add(node33);
        node43.children.Add(node44);

        node44.children.Add(node43);
        node44.children.Add(node45);

        node45.children.Add(node44);
        node45.children.Add(node46);
        node45.children.Add(node55);

        node46.children.Add(node45);
        node46.children.Add(node47);

        node47.children.Add(node37);
        node47.children.Add(node46);
        node47.children.Add(node57);

        node50.children.Add(node40);
        node50.children.Add(node51);
        node50.children.Add(node60);

        node51.children.Add(node50);
        node51.children.Add(node52);
        node51.children.Add(node61);

        node52.children.Add(node42);
        node52.children.Add(node51);
        node52.children.Add(node53);
        node52.children.Add(node62);

        node53.children.Add(node52);
        node53.children.Add(node54);

        node54.children.Add(node53);
        node54.children.Add(node55);

        node55.children.Add(node54);
        node55.children.Add(node45);
        node55.children.Add(node65);

        node56.children.Add(node57);
        node56.children.Add(node66);

        node57.children.Add(node47);
        node57.children.Add(node56);
        node57.children.Add(node67);

        node60.children.Add(node50);
        node60.children.Add(node61);
        node60.children.Add(node70);

        node61.children.Add(node51);
        node61.children.Add(node60);
        node61.children.Add(node71);

        node62.children.Add(node52);
        node62.children.Add(node72);

        node63.children.Add(node64);
        node63.children.Add(node73);

        node64.children.Add(node63);
        node64.children.Add(node65);
        node64.children.Add(node74);

        node65.children.Add(node64);
        node65.children.Add(node55);
        node65.children.Add(node75);

        node66.children.Add(node56);
        node66.children.Add(node76);

        node67.children.Add(node57);
        node67.children.Add(node77);

        node70.children.Add(node60);
        node70.children.Add(node71);
        node70.children.Add(node80);

        node71.children.Add(node61);
        node71.children.Add(node70);
        node71.children.Add(node81);

        node72.children.Add(node62);
        node72.children.Add(node82);

        node73.children.Add(node63);
        node73.children.Add(node74);

        node74.children.Add(node64);
        node74.children.Add(node73);
        node74.children.Add(node75);

        node75.children.Add(node65);
        node75.children.Add(node74);
        node75.children.Add(node85);

        node76.children.Add(node66);
        node76.children.Add(node86);

        node77.children.Add(node67);
        node77.children.Add(node87);

        node80.children.Add(node70);
        node80.children.Add(node81);
        node80.children.Add(node90);

        node81.children.Add(node71);
        node81.children.Add(node80);
        node81.children.Add(node82);

        node82.children.Add(node72);
        node82.children.Add(node81);
        node82.children.Add(node83);
        node82.children.Add(node92);

        node83.children.Add(node82);
        node83.children.Add(node84);

        node83.children.Add(node83);
        node83.children.Add(node85);

        node84.children.Add(node83);
        node84.children.Add(node85);

        node85.children.Add(node75);
        node85.children.Add(node84);
        node85.children.Add(node95);

        node86.children.Add(node76);
        node86.children.Add(node87);

        node87.children.Add(node77);
        node87.children.Add(node86);
        node87.children.Add(node97);

        node90.children.Add(node80);
        node90.children.Add(node100);

        node91.children.Add(node92);
        node91.children.Add(node101);

        node92.children.Add(node82);
        node92.children.Add(node91);

        node93.children.Add(node94);
        node93.children.Add(node103);

        node94.children.Add(node93);
        node94.children.Add(node95);

        node95.children.Add(node85);
        node95.children.Add(node94);
        node95.children.Add(node96);

        node96.children.Add(node95);
        node96.children.Add(node97);

        node97.children.Add(node87);
        node97.children.Add(node96);
        node97.children.Add(node107);

        node100.children.Add(node90);
        node100.children.Add(node101);
        node100.children.Add(node110);

        node101.children.Add(node91);
        node101.children.Add(node100);

        node103.children.Add(node93);
        node103.children.Add(node104);

        node104.children.Add(node103);
        node104.children.Add(node105);
        node104.children.Add(node114);

        node105.children.Add(node104);
        node105.children.Add(node106);

        node106.children.Add(node105);
        node106.children.Add(node107);

        node107.children.Add(node97);
        node107.children.Add(node106);
        node107.children.Add(node117);

        node110.children.Add(node100);
        node110.children.Add(node111);
        node110.children.Add(node120);

        node111.children.Add(node110);
        node111.children.Add(node112);

        node112.children.Add(node111);
        node112.children.Add(node122);

        node113.children.Add(node114);
        node113.children.Add(node123);

        node114.children.Add(node104);
        node114.children.Add(node113);

        node115.children.Add(node116);
        node115.children.Add(node125);

        node116.children.Add(node115);
        node116.children.Add(node117);

        node117.children.Add(node107);
        node117.children.Add(node106);
        node117.children.Add(node127);

        node120.children.Add(node110);
        node120.children.Add(node130);

        node122.children.Add(node112);
        node122.children.Add(node132);

        node123.children.Add(node113);
        node123.children.Add(node124);

        node124.children.Add(node123);
        node124.children.Add(node134);

        node125.children.Add(node115);
        node125.children.Add(node135);

        node127.children.Add(node117);
        node127.children.Add(node137);

        node130.children.Add(node120);
        node130.children.Add(node131);

        node131.children.Add(node130);
        node131.children.Add(node132);

        node132.children.Add(node122);
        node132.children.Add(node131);
        node132.children.Add(node133);

        node133.children.Add(node132);
        node133.children.Add(node134);

        node134.children.Add(node133);
        node134.children.Add(node135);
        node134.children.Add(node124);

        node135.children.Add(node125);
        node135.children.Add(node134);
        node135.children.Add(node136);

        node136.children.Add(node135);
        node136.children.Add(node137);

        node137.children.Add(node136);
        node137.children.Add(node127);
    }

    // Update is called once per frame
   /* void Update()
    {
        Queue<Node> maFile = new Queue<Node>();

        firstNode.depth = 0;

        maFile.Enqueue(firstNode);

        while (maFile.Count > 0)
        {
            Node myNode = maFile.Dequeue(); // retirer le premier parametre

            Console.Write(myNode.SommetDeDepart);

            List<Node> neightbors = myNode.children;

            foreach (Node n in neightbors)
            {
                if (n.depth < 0)
                {
                    n.depth = myNode.depth + 1;
                    maFile.Enqueue(n);

                    if (n == endnode)
                        return n.depth;
                }
            }
        }
        return -1;
    }
    
    }*/
}

/*public class Node : MonoBehaviour
{
    public int SommetDeDepart;
    public int depth;
    public List<Node> children;
    public Node parent;

    public Node(int Depart)
    {
        SommetDeDepart = Depart;
        this.depth = -1;
        children = new List<Node>();

    }
}*/
