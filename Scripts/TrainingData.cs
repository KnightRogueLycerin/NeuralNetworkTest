using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingData
{
    private static List<NeuralNetwork.NetworkModels.DataSet> tratingData = new List<NeuralNetwork.NetworkModels.DataSet>();
    public void initalize()
    {   // Empty
        addTraning(
            new double[]
            {   // Input data, [0,1] -> [off,on]
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
                0, 0, 0, 0,
            },
            new double[]
            {   // Cirkle, Cross
                0, 0
            }
            );
        // Full
        addTraning(
            new double[]
            {   // Input data, [0,1] -> [off,on]
                1, 1, 1, 1,
                1, 1, 1, 1,
                1, 1, 1, 1,
                1, 1, 1, 1,
            },
            new double[]
            {   // Cirkle, Cross
                1, 1
            }
            );
        // Cirkle
        addTraning(
            new double[]
            {   // Input data, [0,1] -> [off,on]
                0, 1, 1, 0,
                1, 0, 0, 1,
                1, 0, 0, 1,
                0, 1, 1, 0,
            },
            new double[]
            {   // Cirkle, Cross
                1, 0
            }
            );
        // Cross
        addTraning(
            new double[]
            {   // Input data, [0,1] -> [off,on]
                1, 0, 0, 1,
                0, 1, 1, 0,
                0, 1, 1, 0,
                1, 0, 0, 1,
            },
            new double[]
            {   // Cirkle, Cross
                0, 1
            }
            );
    }
    private void addTraning(double[] Values, double[] Target)
    {
        tratingData.Add(new NeuralNetwork.NetworkModels.DataSet(Values, Target));
    }
    public List<NeuralNetwork.NetworkModels.DataSet> getTraningData()
    {
        return tratingData;
    }
}
