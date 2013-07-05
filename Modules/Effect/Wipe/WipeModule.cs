﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Controls.ColorManagement.ColorModels;
using Vixen.Module;
using Vixen.Module.Effect;
using Vixen.Sys;
using Vixen.Sys.Attribute;
using VixenModules.App.ColorGradients;
using VixenModules.App.Curves;
using VixenModules.Effect.Pulse;
using VixenModules.Property.Location;

namespace VixenModules.Effect.Wipe {
	public class WipeModule : EffectModuleInstanceBase {
		public WipeModule() {

		}
		WipeData _data = new WipeData();
		private EffectIntents _elementData = null;

		protected override void _PreRender() {

			_elementData = new EffectIntents();

			IEnumerable<IGrouping<int, ElementNode>> renderNodes = null;


			switch (_data.Direction) {
				case WipeDirection.Up:
					renderNodes = TargetNodes.SelectMany(x => x.GetLeafEnumerator())
									.OrderByDescending(x => {
										var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
										if (prop != null) {
											return ((LocationData)prop.ModuleData).Y;
										}
										return 1;
									})
									.ThenBy(x => {
										var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
										if (prop != null) {
											return ((LocationData)prop.ModuleData).X;
										}
										return 1;
									})
									.GroupBy(x => {
										var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
										if (prop != null) {
											return ((LocationData)prop.ModuleData).Y;
										}
										return 1;
									})
									.Distinct();
					break;
				case WipeDirection.Down:
					renderNodes = TargetNodes.SelectMany(x => x.GetLeafEnumerator())
														.OrderBy(x => {
															var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
															if (prop != null) {
																return ((LocationData)prop.ModuleData).Y;
															}
															return 1;
														})
														.ThenBy(x => {
															var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
															if (prop != null) {
																return ((LocationData)prop.ModuleData).X;
															}
															return 1;
														})
														.GroupBy(x => {
															var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
															if (prop != null) {
																return ((LocationData)prop.ModuleData).Y;
															}
															return 1;
														})
														.Distinct();
					break;
				case WipeDirection.Right:
					renderNodes = TargetNodes.SelectMany(x => x.GetLeafEnumerator())
											.OrderBy(x => {
												var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
												if (prop != null) {
													return ((LocationData)prop.ModuleData).X;
												}
												return 1;
											})
											.ThenBy(x => {
												var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
												if (prop != null) {
													return ((LocationData)prop.ModuleData).Y;
												}
												return 1;
											})
											.GroupBy(x => {
												var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
												if (prop != null) {
													return ((LocationData)prop.ModuleData).X;
												}
												return 1;
											})
											.Distinct();
					break;
				case WipeDirection.Left:
				default:
					renderNodes = TargetNodes.SelectMany(x => x.GetLeafEnumerator())
												.OrderByDescending(x => {
													var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
													if (prop != null) {
														return ((LocationData)prop.ModuleData).X;
													}
													return 1;
												})
												.ThenBy(x => {
													var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
													if (prop != null) {
														return ((LocationData)prop.ModuleData).Y;
													}
													return 1;
												})
												.GroupBy(x => {
													var prop = x.Properties.Get(VixenModules.Property.Location.LocationDescriptor._typeId);
													if (prop != null) {
														return ((LocationData)prop.ModuleData).X;
													}
													return 1;
												})
												.Distinct();
					break;

			}


			if (renderNodes != null) {
				double intervals = (double)TimeSpan.TotalMilliseconds / (double)renderNodes.Count();
				var intervalTime = TimeSpan.FromMilliseconds(intervals);

				TimeSpan effectTime = TimeSpan.Zero;
				foreach (var item in renderNodes) {
					EffectIntents result;

					foreach (var element in item) {
						var pulse = new Pulse.Pulse();
						pulse.TargetNodes = new ElementNode[] { element };
						pulse.TimeSpan = TimeSpan;
						pulse.ColorGradient = _data.ColorGradient;
						pulse.LevelCurve = _data.Curve;
						result = pulse.Render();
						result.OffsetAllCommandsByTime(effectTime);
						_elementData.Add(result);
					}
					effectTime += intervalTime;
				}
			}
		}

		protected override EffectIntents _Render() {
			return _elementData;
		}

		public virtual bool IsDirty { get; protected set; }

		public override IModuleDataModel ModuleData {
			get { return _data; }
			set { _data = value as WipeData; }
		}

		[Value]
		public ColorGradient ColorGradient {
			get { return _data.ColorGradient; }
			set {
				_data.ColorGradient = value;
				IsDirty = true;
			}
		}

		[Value]
		public WipeDirection Direction {
			get { return _data.Direction; }
			set {
				_data.Direction = value;
				IsDirty = true;
			}
		}

		[Value]
		public Curve Curve {
			get { return _data.Curve; }
			set {
				_data.Curve = value;
				IsDirty = true;
			}
		}

		[Value]
		public int PulseTime {
			get { return _data.PulseTime; }
			set {
				_data.PulseTime = value;
				IsDirty = true;
			}
		}

		[Value]
		public RGB Color {
			get { return _data.Color; }
			set {
				_data.Color = value;
				IsDirty = true;
			}
		}

		[Value]
		public WipeColorHandling ColorHandling {
			get { return _data.ColorHandling; }
			set {
				_data.ColorHandling = value;
				IsDirty = true;
			}
		}
	}
}
