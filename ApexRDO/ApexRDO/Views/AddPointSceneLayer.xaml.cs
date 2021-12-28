﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace ApexRDO.Views
//{
//	[XamlCompilation(XamlCompilationOptions.Compile)]
//	public partial class AddPointSceneLayer : ContentPage
//	{
//		public AddPointSceneLayer ()
//		{
//			InitializeComponent ();
//		}
//	}
//}
// Copyright 2019 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an 
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific 
// language governing permissions and limitations under the License.

using System;
using Esri.ArcGISRuntime.Mapping;
using Xamarin.Forms;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
using System.Collections.Generic;
using System.Windows;

namespace ArcGISRuntimeXamarin.Samples.AddPointSceneLayer
{
    [ArcGISRuntime.Samples.Shared.Attributes.Sample(
        name: "Add a point scene layer",
        category: "Layers",
        description: "View a point scene layer from a scene service.",
        instructions: "Pan around the scene and zoom in. Notice how many thousands of additional features appear at each successive zoom scale.",
        tags: new[] { "3D", "layers", "point scene layer" })]
    public partial class AddPointSceneLayer : ContentPage
    {
        // URL for the service with the point scene layer.
        private const string PointSceneServiceUri = "https://tiles.arcgis.com/tiles/V6ZHFr6zdgNZuVG0/arcgis/rest/services/Airports_PointSceneLayer/SceneServer/layers/0";

        public AddPointSceneLayer()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            // Create the scene.
            MySceneView.Scene = new Scene(BasemapStyle.ArcGISImageryStandard);

            // Create the layer.
            ArcGISSceneLayer pointSceneLayer = new ArcGISSceneLayer(new Uri(PointSceneServiceUri));

            // Show the layer in the scene.
            MySceneView.Scene.OperationalLayers.Add(pointSceneLayer);
        }
    }
}