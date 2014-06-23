﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMeta2.Enumerations
{
    /// <summary>
    /// Web templates generated by categories.
    /// </summary>
    public static class BuiltInWebTemplates
    {
        /// <summary>
        /// A base template for app development.  It provides the minimal set of features needed for an app.
        /// </summary>
        public static readonly string AppTemplate = "APP#0";

        /// <summary>
        /// A site for sharing apps for SharePoint and Office
        /// </summary>
        public static readonly string AppCatalogSite = "APPCATALOG#0";

        /// <summary>
        /// A site for central administration. It provides Web pages and links for application and operations management.
        /// </summary>
        public static readonly string CentralAdminSite = "CENTRALADMIN#0";

        /// <summary>
        /// This template is used for initializing a new site.
        /// </summary>
        public static readonly string GlobalTemplate = "GLOBAL#0";

        /// <summary>
        /// This template creates a site for administering shared services
        /// </summary>
        public static readonly string SharedServicesAdministrationSite = "OSRV#0";

        /// <summary>
        /// This template creates a profile site that includes page layout with zones
        /// </summary>
        public static readonly string Profiles = "PROFILES#0";

        /// <summary>
        /// This template is obsolete.
        /// </summary>
        public static readonly string SharePointPortalServerSite = "SPS#0";

        /// <summary>
        /// This template is obsolete.
        /// </summary>
        public static readonly string CommunityAreaTemplate = "SPSCOMMU#0";

        /// <summary>
        /// This template is obsolete.
        /// </summary>
        public static readonly string NewsSite = "SPSNEWS#0";

        /// <summary>
        /// This web template defines a Personal Space for an individual participating on a SharePoint Portal.
        /// </summary>
        public static readonly string SharePointPortalServerPersonalSpace = "SPSPERS#0";

        /// <summary>
        /// This web template defines a minimal Personal Space with both Social and Storage features for an individual participating on a SharePoint Portal.
        /// </summary>
        public static readonly string StorageAndSocialSharePointPortalServerPersonalSpace = "SPSPERS#2";

        /// <summary>
        /// This web template defines a minimal Personal Space with Storage features for an individual participating on a SharePoint Portal.
        /// </summary>
        public static readonly string StorageOnlySharePointPortalServerPersonalSpace = "SPSPERS#3";

        /// <summary>
        /// This web template defines a minimal Personal Space with Social features for an individual participating on a SharePoint Portal.
        /// </summary>
        public static readonly string SocialOnlySharePointPortalServerPersonalSpace = "SPSPERS#4";

        /// <summary>
        /// This web template defines a empty Personal Space.
        /// </summary>
        public static readonly string EmptySharePointPortalServerPersonalSpace = "SPSPERS#5";

        /// <summary>
        /// This template is obsolete.
        /// </summary>
        public static readonly string ContentsAreaTemplate = "SPSTOC#0";

        /// <summary>
        /// This template is obsolete.
        /// </summary>
        public static readonly string TopicAreaTemplate = "SPSTOPIC#0";

        /// <summary>
        /// A site for tenant administration. It provides Web pages and links for self-serve administration.
        /// </summary>
        public static readonly string TenantAdminSite = "TENANTADMIN#0";


        /// <summary>
        /// SharePoint web templates under category 'Collaboration'.
        /// </summary>
        public static class Collaboration
        {
            /// <summary>
            /// Microsoft Access Server
            /// </summary>
            public static readonly string AccessServicesSite_SRV0 = "ACCSRV#0";

            /// <summary>
            /// Microsoft Access Server Internal
            /// </summary>
            public static readonly string AccessServicesSiteInternal = "ACCSVC#0";

            /// <summary>
            /// Microsoft Access Server
            /// </summary>
            public static readonly string AccessServicesSite = "ACCSVC#1";

            /// <summary>
            /// A site for a person or team to post ideas, observations, and expertise that site visitors can comment on.
            /// </summary>
            public static readonly string Blog = "BLOG#0";

            /// <summary>
            /// A place where community members discuss topics of common interest. Members can browse and discover relevant content by exploring categories, sorting discussions by popularity or by viewing only posts that have a best reply. Members gain reputation points by participating in the community, such as starting discussions and replying to them, liking posts and specifying best replies.
            /// </summary>
            public static readonly string CommunitySite = "COMMUNITY#0";

            /// <summary>
            /// A site for developers to build, test and publish apps for Office
            /// </summary>
            public static readonly string DeveloperSite = "DEV#0";

            /// <summary>
            /// A site for managing and collaborating on a project. This site template brings all status, communication, and artifacts relevant to the project into one place.
            /// </summary>
            public static readonly string ProjectSite = "PROJECTSITE#0";

            /// <summary>
            /// This template provides a groupware solution that enables teams to create, organize, and share information quickly and easily. It includes Group Calendar, Circulation, Phone-Call Memo, the Document Library and the other basic lists.
            /// </summary>
            public static readonly string GroupWorkSite = "SGS#0";

            /// <summary>
            /// A place to work together with a group of people.
            /// </summary>
            public static readonly string TeamSite = "STS#0";

            /// <summary>
            /// A blank site for you to customize based on your requirements.
            /// </summary>
            public static readonly string BlankSite = "STS#1";

            /// <summary>
            /// A site for colleagues to work together on a document. It provides a document library for storing the primary document and supporting files, a tasks list for assigning to-do items, and a links list for resources related to the document.
            /// </summary>
            public static readonly string DocumentWorkspace = "STS#2";

            /// <summary>
            /// A site for teams to quickly view, share, and store Visio process diagrams. It provides a versioned document library for storing process diagrams, and lists for managing announcements, tasks, and review discussions.
            /// </summary>
            public static readonly string VisioProcessRepository = "visprus#0";

            /// <summary>
            /// A site for a community to brainstorm and share ideas. It provides Web pages that can be quickly edited to record information and then linked together through keywords
            /// </summary>
            public static readonly string WikiSite = "WIKI#0";

        }

        /// <summary>
        /// SharePoint web templates under category 'Enterprise'.
        /// </summary>
        public static class Enterprise
        {
            /// <summary>
            /// A site to centrally manage documents in your enterprise.
            /// </summary>
            public static readonly string DocumentCenter = "BDR#0";

            /// <summary>
            /// A site for presenting Business Intelligence Center.
            /// </summary>
            public static readonly string BusinessIntelligenceCenter = "BICenterSite#0";

            /// <summary>
            /// A site for discovering communities.
            /// </summary>
            public static readonly string CommunityPortal = "COMMUNITYPORTAL#0";

            /// <summary>
            /// A site to manage the preservation, search, and export of content for legal matters and investigations.
            /// </summary>
            public static readonly string eDiscoveryCenter = "EDISC#0";

            /// <summary>
            /// This template creates an eDiscovery case. Users create locations where they can preserve or export data.
            /// </summary>
            public static readonly string eDiscoveryCase = "EDISC#1";

            /// <summary>
            /// (obsolete) This template creates a site designed for records management. Records managers can configure the routing table to direct incoming files to specific locations. The site also lets you manage whether records can be deleted or modified after they are added to the repository.
            /// </summary>
            public static readonly string _obsoleteRecordsCenter = "OFFILE#0";

            /// <summary>
            /// This template creates a site designed for records management. Records managers can configure the routing table to direct incoming files to specific locations. The site also lets you manage whether records can be deleted or modified after they are added to the repository.
            /// </summary>
            public static readonly string RecordsCenter = "OFFILE#1";

            /// <summary>
            /// A site for presenting PerformancePoint dashboards and scorecards. The site also includes links to PerformancePoint Dashboard Designer and storage for dashboard content such as analytic charts, reports, KPIs, and strategy maps.
            /// </summary>
            public static readonly string PerformancePoint = "PPSMASite#0";

            /// <summary>
            /// A site for delivering personalized views, data, and navigation from this site collection into My Site. It includes personalization specific Web Parts and navigation that is optimized for My Site sites.
            /// </summary>
            public static readonly string PersonalizationSite = "SPSMSITE#0";

            /// <summary>
            /// A site used for hosting personal sites (My Sites) and the public People Profile page. This template needs to be provisioned only once per User Profile Service Application, please consult the documentation for details.
            /// </summary>
            public static readonly string MySiteHost = "SPSMSITEHOST#0";

            /// <summary>
            /// A site for creating, managing, and delivering Web pages, dashboards, and key performance indicators that communicate metrics, goals, and business intelligence information.
            /// </summary>
            public static readonly string ReportCenter = "SPSREPORTCENTER#0";

            /// <summary>
            /// A site for listing and categorizing important sites in your organization. It includes different views for categorized sites, top sites, and a site map.
            /// </summary>
            public static readonly string SiteDirectory = "SPSSITES#0";

            /// <summary>
            /// A site focused on delivering an enterprise-wide search experience. Includes a welcome page with a search box that connects users to four search results page experiences: one for general searches, one for people searches, one for conversation searches, and one for video searches. You can add and customize new results pages to focus on other types of search queries.
            /// </summary>
            public static readonly string EnterpriseSearchCenter = "SRCHCEN#0";

            /// <summary>
            /// A site for delivering the FAST search experience. The welcome page includes a search box with two tabs: one for general searches, and another for searches for information about people. You can add and customize tabs to focus on other search scopes or result types.
            /// </summary>
            public static readonly string FASTSearchCenter = "SRCHCENTERFAST#0";

            /// <summary>
            /// A site for delivering the search experience. The site includes pages for search results and advanced searches.
            /// </summary>
            public static readonly string BasicSearchCenter_Lite0 = "SRCHCENTERLITE#0";

            /// <summary>
            /// The Search Center template creates pages dedicated to search. The main welcome page features a simple search box in the center of the page. The template includes a search results and an advanced search page. This Search Center will not appear in navigation.
            /// </summary>
            public static readonly string BasicSearchCenter_Lite1 = "SRCHCENTERLITE#1";

        }

        /// <summary>
        /// SharePoint web templates under category 'Meetings'.
        /// </summary>
        public static class Meetings
        {
            /// <summary>
            /// A site to plan, organize, and capture the results of a meeting. It provides lists for managing the agenda, meeting attendees, and documents.
            /// </summary>
            public static readonly string BasicMeetingWorkspace = "MPS#0";

            /// <summary>
            /// A blank meeting site for you to customize based on your requirements.
            /// </summary>
            public static readonly string BlankMeetingWorkspace = "MPS#1";

            /// <summary>
            /// A site for meetings that track status or make decisions. It provides lists for creating tasks, storing documents, and recording decisions.
            /// </summary>
            public static readonly string DecisionMeetingWorkspace = "MPS#2";

            /// <summary>
            /// A site to plan social occasions. It provides lists for tracking attendees, providing directions, and storing pictures of the event.
            /// </summary>
            public static readonly string SocialMeetingWorkspace = "MPS#3";

            /// <summary>
            /// A site to plan, organize, and capture the results of a meeting. It provides lists for managing the agenda and meeting attendees in addition to two blank pages for you to customize based on your requirements.
            /// </summary>
            public static readonly string MultipageMeetingWorkspace = "MPS#4";

        }

        /// <summary>
        /// SharePoint web templates under category 'Publishing'.
        /// </summary>
        public static class Publishing
        {
            /// <summary>
            /// This template creates a site for publishing Web pages on a schedule, with workflow features enabled.  By default, only Publishing subsites can be created under this site. A Document and Picture Library are included for storing Web publishing assets.
            /// </summary>
            public static readonly string PublishingSite_Intranet = "BLANKINTERNET#0";

            /// <summary>
            /// This template creates the Press Releases subsite for an Internet-facing corporate presence website.
            /// </summary>
            public static readonly string PressReleasesSite = "BLANKINTERNET#1";

            /// <summary>
            /// A site for publishing Web pages on a schedule by using approval workflows. It includes document and image libraries for storing Web publishing assets. By default, only sites with this template can be created under this site.
            /// </summary>
            public static readonly string PublishingSiteWithWorkflow = "BLANKINTERNET#2";

            /// <summary>
            /// A starter site hierarchy for an Internet-facing site or a large intranet portal. This site can be customized easily with distinctive branding. It includes a home page, a sample press releases subsite, a Search Center, and a login page. Typically, this site has many more readers than contributors, and it is used to publish Web pages with approval workflows.
            /// </summary>
            public static readonly string PublishingPortal = "BLANKINTERNETCONTAINER#0";

            /// <summary>
            /// A blank site for expanding your Web site and quickly publishing Web pages. Contributors can work on draft versions of pages and publish them to make them visible to readers. The site includes  document and image libraries for storing Web publishing assets.
            /// </summary>
            public static readonly string PublishingSite_CMS = "CMSPUBLISHING#0";

            /// <summary>
            /// The Academic Library template provides a rich view and consumption experience for published content and management. Authors populate metadata and apply rules at the time of publishing, such as description, licensing, and optional rights management (IRM). Visitors of the site can search or browse published titles and add authorized selections to their collection to consume, subject to the rights and rules applied by the author. The site provides an IRM-capable document library, a publishing mechanism for authors to publish documents, detailed views for each document, a check-out mechanism, and related search capabilities.
            /// </summary>
            public static readonly string AcademicLibrary = "DOCMARKETPLACESITE#0";

            /// <summary>
            /// A site for publishing knowledge that you capture and want to share across the enterprise. It provides an easy content editing experience in a single location for co-authoring content, discussions, and project management.
            /// </summary>
            public static readonly string EnterpriseWiki = "ENTERWIKI#0";

            /// <summary>
            /// A site for managing product catalog data which can be published to  an internet-facing site through search. The product catalog can be configured to support product variants and multilingual product properties.  The site includes admin pages for managing faceted navigation for products.
            /// </summary>
            public static readonly string ProductCatalog = "PRODUCTCATALOG#0";

            /// <summary>
            /// A site for publishing news articles and links to news articles. It includes a sample news page and an archive for storing older news items.
            /// </summary>
            public static readonly string NewsSite = "SPSNHOME#0";

            /// <summary>
            /// A starter site hierarchy for an intranet divisional portal. It includes a home page, a News site, a Site Directory, a Document Center, and a Search Center with Tabs. Typically, this site has nearly as many contributors as  readers and is used to host team sites.
            /// </summary>
            public static readonly string CollaborationPortal = "SPSPORTAL#0";

        }

        /// <summary>
        /// SharePoint web templates under category 'WebDatabases'.
        /// </summary>
        public static class WebDatabases
        {
            /// <summary>
            /// Create an assets database to keep track of assets, including asset details and owners.
            /// </summary>
            public static readonly string AssetsWebDatabase_SRV1 = "ACCSRV#1";

            /// <summary>
            /// Create a database to track information about fundraising campaigns including donations made by contributors, campaign related events, and pending tasks.
            /// </summary>
            public static readonly string CharitableContributionsWebDatabase = "ACCSRV#3";

            /// <summary>
            /// Create a contacts database to manage information about people that your team works with, such as customers and partners.
            /// </summary>
            public static readonly string ContactsWebDatabase = "ACCSRV#4";

            /// <summary>
            /// Create a project tracking database to track multiple projects, and assign tasks to different people.
            /// </summary>
            public static readonly string ProjectsWebDatabase = "ACCSRV#5";

            /// <summary>
            /// Create an issues database to manage a set of issues or problems. You can assign, prioritize, and follow the progress of issues from start to finish.
            /// </summary>
            public static readonly string IssuesWebDatabase = "ACCSRV#6";

        }



    }
}
