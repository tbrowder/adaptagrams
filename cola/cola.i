/* File : cola.i */
%module cola

%{
#include <vector>
#include <libvpsc/rectangle.h>
#include <libcola/cola.h>
#include <libcola/cluster.h>
#include <libcola/compound_constraints.h>
#include <libtopology/topology_graph.h>
/* Includes the header in the wrapper code */

/*using namespace Avoid;*/
using namespace cola;
using namespace vpsc;
using namespace topology;
%}

%ignore cola::PreIteration::operator();
//%ignore cola::TestConvergence::operator();
%ignore operator<<(std::ostream &os, vpsc::Rectangle const &r);
%ignore vpsc::Rectangle::setXBorder(double);
%ignore vpsc::Rectangle::setYBorder(double);
%ignore vpsc::assertNoOverlaps(const Rectangles& rs);
%ignore Avoid::point::operator==(Avoid::point const &) const;
%ignore Avoid::point::operator!=(Avoid::point const &) const;
%ignore cola::Resize::Resize();
%ignore topology::Segment;
%ignore topology::EdgePoint::inSegment;
%ignore topology::EdgePoint::outSegment;
%ignore topology::EdgePoint::bendConstraint;
%ignore topology::EdgePoint::prune();
%ignore topology::EdgePoint::getBendConstraint(std::vector<TopologyConstraint*>* ts);
%ignore topology::EdgePoint::createBendConstraint();
%ignore topology::EdgePoint::deleteBendConstraint();
%ignore topology::Edge::firstSegment;
%ignore topology::Edge::lastSegment;
%ignore topology::Edge::getTopologyConstraints(std::vector<TopologyConstraint*>* ts) const;
%ignore topology::Edge::getRoute() const;
%ignore topology::Edge::toString() const;
%ignore topology::Edge::toString() const;
%ignore topology::assertConvexBends(const Edges&);
%ignore topology::assertNoSegmentRectIntersection(const Nodes&, const Edges&);
%ignore topology::assertNoZeroLengthEdgeSegments(const Edges& es);
%ignore topology::compute_stress(const Edges&);
%ignore topology::printEdges(const Edges&);

%include "std_vector.i"
%include "std_pair.i"

%template(EdgeVector) std::vector<cola::Edge>;
%template(ColaEdge) std::pair<unsigned,unsigned>;
%template(OffsetPair) std::pair<unsigned,double>;
%template(OffsetList) std::vector<std::pair<unsigned,double> >;
%template(RectPtrVector) std::vector<vpsc::Rectangle*>;
%template(CompoundConstraintsVector) std::vector<cola::CompoundConstraint*>;
%template(ColaLocks) std::vector<cola::Lock>;
%template(ColaResizes) std::vector<cola::Resize>;
%template(TopologyEdgePointPtrVector) std::vector<topology::EdgePoint*>;
%template(TopologyEdgePointConstPtrVector) std::vector<const topology::EdgePoint*>;
%template(TopologyEdgePtrVector) std::vector<topology::Edge*>;
%template(TopologyNodePtrVector) std::vector<topology::Node*>;
%template(UnsignedVector) std::vector<unsigned>;
%template(ClusterVector) std::vector<cola::Cluster*>;

%inline %{
double *a;
void doubleArraySet(double *a, int i, double val) {
   a[i] = val;
}
double doubleArrayGet(const double *a, int i) {
   return a[i];
}
double *newDoubleArray(int size) {
   return new double[size];
}
void deleteDoubleArray(double* a) {
   delete a;
}
%}


%rename(testoperator) cola::TestConvergence::operator();

//%rename straightener::Edge StraightenerEdge;

/* Parse the header file to generate wrappers */
%include "libvpsc/rectangle.h"
%include "libcola/cola.h"
%include "libcola/cluster.h"
%include "libcola/compound_constraints.h"
%include "libtopology/topology_graph.h"

/*
%include "libavoid/connector.h"
%include "libavoid/debug.h"
%include "libavoid/geometry.h"
%include "libavoid/geomtypes.h"
%include "libavoid/graph.h"
%include "libavoid/libavoid.h"
%include "libavoid/makepath.h"
%include "libavoid/polyutil.h"
%include "libavoid/region.h"
%include "libavoid/router.h"
%include "libavoid/shape.h"
%include "libavoid/static.h"
%include "libavoid/timer.h"
%include "libavoid/visibility.h"
%include "libcola/cluster.h"
//%include "libcola/cola.h"
%include "libcola/cola_log.h"
%include "libcola/conjugate_gradient.h"
%include "libcola/connected_components.h"
%include "libcola/convex_hull.h"
%include "libcola/gradient_projection.h"
%include "libcola/max_acyclic_subgraph.h"
%include "libcola/output_svg.h"
%include "libcola/shortest_paths.h"
%include "libcola/sparse_matrix.h"
%include "libproject/project.h"
%include "libproject/variable.h"
%include "libtopology/topology_constraints.h"
%include "libtopology/topology_graph.h"
%include "libtopology/topology_log.h"
%include "libtopology/util.h"
%include "libvpsc/block.h"
%include "libvpsc/blocks.h"
%include "libvpsc/cbuffer.h"
%include "libvpsc/constraint.h"
%include "libvpsc/csolve_VPSC.h"
%include "libvpsc/exceptions.h"
%include "libvpsc/isnan.h"
%include "libvpsc/linesegment.h"
%include "libvpsc/mosek_quad_solve.h"
//%include "libvpsc/rectangle.h"
%include "libvpsc/solve_VPSC.h"
%include "libvpsc/variable.h"
*/