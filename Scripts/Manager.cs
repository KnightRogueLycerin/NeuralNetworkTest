using NeuralNetwork.NetworkModels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    [Header("Outputs")]
    [SerializeField]
    public Output output;

    [Header("Inputs")]
    [SerializeField]
    public List<Input> inputs = new List<Input>();

    [Header("Artificial Neural Network")]
    [SerializeField]
    public bool UseEpoch = true;
    public double MinimumError = 0.000000001;
    public int MaxEpoch = 1;
    public int[] NeuronsInHiddenLayers = { 2 };

    private int _numInputParameters;
    private int _numOutputParameters = 2;
    private NeuralNetwork.NetworkModels.Network _network;
    private List<DataSet> _dataSets;
    private TrainingData trainer = new TrainingData();
    // Used for input translation
    double[] outputData;

    // Use this for initialization
    void Start () {
        // Setting up variables
        trainer.initalize();
        _numInputParameters = inputs.Count;
        // Initialization of network
        _network = new NeuralNetwork.NetworkModels.Network(
            _numInputParameters,
            NeuronsInHiddenLayers,
            _numOutputParameters);
        // Train the network
        if (UseEpoch)
        {
            _network.Train(trainer.getTraningData(), MaxEpoch);
        }else
        {
            _network.Train(trainer.getTraningData(), MinimumError);
        }
        // Shuffle initial board
        foreach (Input i in inputs){
            if(Random.Range(0f, 2f) <= 1f){
                i.button();
            }
        }
        output.set(0d, 1d);
    }
	
	// Update is called once per frame
	void Update () {
        // Read input
        var inputData = new double[_numInputParameters];
        for (int i = 0; i < _numInputParameters; i++)
        {
            inputData[i] = inputs[i].get();
        }
        // Compute output
        outputData = _network.Compute(inputData);
        output.set(outputData[0], outputData[1]);
    }
}
